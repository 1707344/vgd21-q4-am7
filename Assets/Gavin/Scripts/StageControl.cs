using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageControl : MonoBehaviour
{
    public Transform markerParent;
    public float distance;
    Transform[] markers;
    public Transform player;
    public Transform cameraTransform;
    public bool canContinue = false;
    public int inMarker;//Which marker is the player in
    public NextStage nextStage;

    // Start is called before the first frame update
    void Start()
    {
        inMarker = 0;
        markers = new Transform[markerParent.childCount];
        for (int i = 0; i < markerParent.childCount; i++)
        {
            markers[i] = markerParent.GetChild(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform marker in markers)
        {
            if (Mathf.Abs(player.position.x - marker.position.x) <= distance)
            {
                cameraTransform.position = new Vector3(marker.position.x, marker.position.y, cameraTransform.position.z);

                


                for (int i = 0; i < markers.Length; i++)
                {
                    if(markers[i] == marker)
                    {
                        if(markers[i].tag == "Final Marker")
                        {
                            SceneManager.LoadScene("EndScreen");
                        }
                        if(inMarker != i)
                        {
                            nextStage.Reset(markers[i].position.x);
                        }
                        inMarker = i;
                        break;
                    }
                }

                float right = marker.position.x - (marker.localScale.x / 2f) + 0.2f;
                float left = marker.position.x + (marker.localScale.x / 2f) - 0.2f;


                if (player.position.x > left && !canContinue)
                {
                    player.position = new Vector3(left, player.position.y, player.position.z);
                }
                else if (player.position.x < right )
                {
                    player.position = new Vector3(right, player.position.y, player.position.z);
                }
            }
        }
    }
}