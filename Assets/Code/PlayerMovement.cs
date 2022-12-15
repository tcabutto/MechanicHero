using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    private Vector2 movement;
    private Rigidbody2D rbody;

    //Gets RigidBody component on Awake
    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    //Calls Movment method on FixedUpdate
    void FixedUpdate()
    {
        Movement();
    }

    //Gets the InputValue and sets it to the movment veriable
    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    //Movment method that moves the player object based on movement speed and the InputValue
    private void Movement()
    {
        Vector2 currentPos = rbody.position;

        Vector2 adjustedMovement = movement * movementSpeed;

        Vector2 newPos = currentPos + adjustedMovement * Time.fixedDeltaTime;

        rbody.MovePosition(newPos);
    }
    //Rotates player towards direction of movment (Does not work IDK why)
    public void RotateTowardDirection()
    {
        if (movement != Vector2.zero)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, movement);
        }
    }
}
