using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using Unity.VisualScripting;

namespace EnemySCP
{


    public class ScpRadio : MonoBehaviour
    {
        private void ActivateRadio()
        {
            if (gameObject.activeSelf)
            {
                gameObject.SetActive(false);
                transform.position = new Vector3(0f, 1, 0f);
            }
            else
            {
                gameObject.SetActive(true);
                transform.position = new Vector3(0.5f, 1, 0.5f);
            }



        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player") && gameObject.transform.parent != collision.gameObject.transform)
            {
                Iventory.AddItem(Iventory.inventory.Count, gameObject.name);
                gameObject.SetActive(false);
                gameObject.transform.parent = collision.gameObject.transform;
            }
        }





    }
}