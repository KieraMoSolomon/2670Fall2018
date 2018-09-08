using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{

    public MovePattern Movement;

    public FloatData MoveX, MoveY, MoveZ;
    
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
        
        if (controller.isGrounded) {
            moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= Movement.speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = Movement.jumpSpeed;
            
        }
        moveDirection.y -= Movement.gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}