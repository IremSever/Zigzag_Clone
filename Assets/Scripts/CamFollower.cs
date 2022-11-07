using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollower : MonoBehaviour
{

    public Transform playerLocation;
    Vector3 distance;
    
    void Start()
    {
        distance = transform.position - playerLocation.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.is_that_fall == false)
        {
            transform.position = playerLocation.position + distance;
        }
    }
}
