using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class MoveCam : MonoBehaviour
    {
        public Transform cam;

        void Update()
        {
            transform.position = cam.position;
        }
    }
}