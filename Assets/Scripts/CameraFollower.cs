using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    public float zoom = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zoom += Input.mouseScrollDelta.y * -1;
        transform.position = new Vector3(player.position.x, zoom, player.position.z);
    }
}
