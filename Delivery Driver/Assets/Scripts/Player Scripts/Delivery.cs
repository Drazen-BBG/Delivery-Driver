using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You Collided, Ouch!!!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Package picked up!");

        }
        
        if (collision.tag == "Customer")
        {
            Debug.Log("Package delivered!");

        }
    }
}
