using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Bottom_Door" && Input.GetKey(KeyCode.E))
        {
            transform.position = new Vector3(0, 5.01f, 9.9f);
        }


        if(other.tag == "Top_Door" && Input.GetKey(KeyCode.E))
        {
            transform.position = new Vector3(3.362224f, 1.251076f, 0.01703999f);
        }
    }
}
