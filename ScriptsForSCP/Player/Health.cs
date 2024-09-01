using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public static class Health
    {

        public static int healthPlayer = 100;
        public static bool isLive = true;


        public static void TakeDamage(int damage)
        {

            if (healthPlayer - damage <= 0)
            {
                isLive = false;
            }
            else
            {
                healthPlayer -= damage;
            }
        }

    }
    public static class Speed
    {
        public static float speed = 10f;

        public static void ChangeSpeed(float newSpeed)
        {
            if (speed - newSpeed <= 0)
            {

            }
            else
            {
                speed += newSpeed;
            }
        }

    }
}