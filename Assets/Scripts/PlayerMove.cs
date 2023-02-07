using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward*0.5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(transform.right*-0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward*-0.5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(transform.right*0.5f);
        }
        if (GetComponent<Rigidbody>().position.y < -5)
        {
            transform.position = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Trap")
        {
            GetComponent<Rigidbody>().AddForce(collision.contacts[0].normal * 150f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("You Win!");
    }
}
