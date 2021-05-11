using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControl : MonoBehaviour
{
    public Transform markerParent;
    public float distance;
    Transform[] markers;
    public Transform player;
    public Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
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

                float right = marker.position.x - (marker.localScale.x / 2f) + 1;
                float left = marker.position.x + (marker.localScale.x / 2f) - 1;


                if (player.position.x > left)
                {
                    player.position = new Vector3(left, player.position.y, player.position.z);
                }
                else if (player.position.x < right)
                {
                    player.position = new Vector3(right, player.position.y, player.position.z);
                }
            }
        }
    }
}