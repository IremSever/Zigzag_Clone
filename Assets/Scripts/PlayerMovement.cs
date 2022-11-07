using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public SpawnGround groundSpawnScript;
    public static bool is_that_fall;
    public float addSpeed;


    void Start()
    {
        direction = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if(is_that_fall == true)
        {
            
            return;
        }

        if(transform.position.y<=0.5f)
        {
            is_that_fall = true;
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(direction.x==0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }

            speed += addSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = direction * Time.deltaTime * speed;
        transform.position += movement;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            groundSpawnScript.create_ground();
            StartCoroutine(DestroyGround(collision.gameObject));
        }
    }

   
    IEnumerator DestroyGround(GameObject DeleteGround)
    {
        yield return new WaitForSeconds(3f);
        Destroy(DeleteGround);
    }
}
