using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 100.0f;
    [SerializeField] float moveSpeed = 10.0f;

    [SerializeField] float slowSpeed = 5.0f;
    [SerializeField] float boostSpeed = 15.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boost" && moveSpeed != boostSpeed)
        {
            Debug.Log("Boost me!");
            moveSpeed = boostSpeed;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Obstacle")
        {
            Debug.Log("I am slow now!");
            moveSpeed = slowSpeed;
        }

    }
}
