using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSensitivity = 100;
    public Transform capsule;
    float xRotate = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        capsule.Rotate(Vector3.up * mouseX);
        xRotate -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);
    }
}