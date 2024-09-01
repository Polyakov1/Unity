using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using ForButtonInMenu;
using System;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {


      
        [Header("Movement")]
        public float jumpForce;
        public float jumpCooldown;
        public float airMultiPlier;
        private bool readyToJump;
        public float groudDrag;


        [Header("KeyBinds")]
        public KeyCode jumpKey = KeyCode.Space;

        [Header("Groud Check")]
        public float playerHeight;
        public LayerMask whatIsGround;

        private bool grounded;


        public Transform orentation;
        private float horizotalInput;
        private float verticalInput;

        Vector3 moveDirection;
        Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;
            readyToJump = true;

        }
        private void MyInput()
        {
            horizotalInput = Input.GetAxisRaw("Horizontal");
            verticalInput = Input.GetAxisRaw("Vertical");

            if (Input.GetKey(jumpKey) && readyToJump && grounded)
            {
                readyToJump = false;
                Jump();
                Invoke(nameof(ResetJump), jumpCooldown);
            }
        }
        private void MovePlayer()
        {
            moveDirection = orentation.forward * verticalInput + orentation.right * horizotalInput;

            if (grounded)
            {
                rb.AddForce(moveDirection.normalized * Speed.speed * 10f, ForceMode.Force);
                CheckGround();
            }

            else if (!grounded)
            {
                rb.AddForce(moveDirection.normalized * Speed.speed * 10f * airMultiPlier, ForceMode.Force);
            }
        }

        private void Update()
        {
            grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.3f, whatIsGround);

            MyInput();
            SpeedControl();

            if (grounded) { rb.drag = groudDrag; }
            else { rb.drag = 0f; }
        }
        private void FixedUpdate()
        {
            if (Health.isLive)
            {
                MovePlayer();
            }
        }

        private void SpeedControl()
        {
            Vector3 flatvel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

            if (flatvel.magnitude > Speed.speed)
            {
                Vector3 limitedvel = flatvel.normalized * Speed.speed;
                rb.velocity = new Vector3(limitedvel.x, rb.velocity.y, limitedvel.z);
            }
        }


        private void Jump()
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        private void ResetJump()
        {
            readyToJump = true;
        }

        private void CheckGround()
        {
            switch (whatIsGround)
            {
                case 0:
                    break;
                case 1:
                    break;
            }


        }
       
    }
}