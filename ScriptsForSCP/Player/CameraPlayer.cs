using ForButtonInMenu;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class CameraPlayer : MonoBehaviour
    {
        public Transform playerBody;
        private float xRotation;
        private float yRotation;

        private void RotateCamera()
        {
            float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * DefaultSettingsInfo.sensMouse;
            float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * DefaultSettingsInfo.sensMouse;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -45f, 45f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);


        }
            
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void Update()
        {

            RotateCamera();
        }
    }
}