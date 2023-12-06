using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBounce : MonoBehaviour
{
    public float bigBounce;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {

            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * bigBounce);

        }

    }
}
