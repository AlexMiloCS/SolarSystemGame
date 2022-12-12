using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 30f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Y Axis");
 
    Vector3 move = transform.right * x + transform.forward * z+ transform.up * y;
        
        controller.Move(move * speed * Time.deltaTime);
    }
}
