using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private float xRotation;
    private float yRotation;
    public float sensX;
    public float sensY;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.Escape)){
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        transform.position = player.transform.position;

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        player.transform.rotation = Quaternion.Euler(0, yRotation, 0);



        

    }
}
