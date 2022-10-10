using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRigidBody;

    float hiz = 5.0f;
    float nZbound = -5.5f;
    float pZbound = 3.5f;

    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerMove();
        ConstrainPlayer();
    }

    void PlayerMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRigidBody.velocity = new Vector3(horizontalInput, 0, verticalInput) * hiz;
    }

    void ConstrainPlayer()
    {
        if (transform.position.z < nZbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, nZbound);
        }

        if (transform.position.z > pZbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, pZbound);
        }
    }

}
