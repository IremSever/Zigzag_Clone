using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    public GameObject last_ground;

    void Start()
    {
        for(int i=0; i<15; i++)
        {
            create_ground();
        }
    }
    public void create_ground()
    {
        Vector3 direction;

        if(Random.Range(0, 2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }


        last_ground = Instantiate(last_ground, last_ground.transform.position + direction, last_ground.transform.rotation);
    }
}
