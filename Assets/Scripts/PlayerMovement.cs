using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D PlayerBody;

    KeyCode LeftArrow;
    KeyCode RightArrow;
    KeyCode UpArrow;
    KeyCode DownArrow;

    private void Start() {
      PlayerBody = GetComponent<Rigidbody2D>();
      PlayerBody.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        // if (Input.GetKeyDown(KeyCode.LeftArrow) && PlayerBody.isKinematic == true)
        // {
        //     PlayerBody.isKinematic = false;
        //     PlayerBody.velocity = new Vector3(0, 0, speed);
        //     PlayerBody.angularDrag = 1;
        // }
        // if (Input.GetKeyDown(KeyCode.RightArrow) && PlayerBody.isKinematic == true)
        // {
        //     PlayerBody.isKinematic = false;
        //     PlayerBody.velocity = new Vector3(0, 0, -speed);
        //     PlayerBody.angularDrag = 2;
        // }
        // if (Input.GetKeyDown(KeyCode.UpArrow) && PlayerBody.isKinematic == true)
        // {
        //     PlayerBody.isKinematic = false;
        //     PlayerBody.velocity = new Vector3(speed, 0, 0);
        //     PlayerBody.angularDrag = 3;
        // }
        // if (Input.GetKeyDown(KeyCode.DownArrow) && PlayerBody.isKinematic == true)
        // {
        //     PlayerBody.isKinematic = false;
        //     PlayerBody.velocity = new Vector3(-speed, 0, 0);
        //     PlayerBody.angularDrag = 4;
        // }

        PlayerBody.isKinematic = false;
        float moveHorzontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorzontal, moveVertical);
        PlayerBody.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        PlayerBody.isKinematic = true;
    }
}
