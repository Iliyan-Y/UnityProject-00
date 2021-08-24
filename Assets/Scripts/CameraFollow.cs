using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    private Transform player; 
    private Vector3 tempCameraPosition;

    
    private float minX = -24.88f;
    private float maxX = 24.87f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        tempCameraPosition = transform.position;
        

        if (player.position.x > maxX) {
            tempCameraPosition.x = maxX;
        } else if (player.position.x < minX) {
            tempCameraPosition.x = minX;
        } else {
            tempCameraPosition.x = player.position.x;
        }
        
        transform.position = tempCameraPosition;
    }
}
