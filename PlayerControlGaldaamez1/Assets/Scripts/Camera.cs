using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float turnSpeed = 100.0f;
    private float speed = 12.0f;
    private float horizontalInput;
    private float verticalInput;
    public Camera mainCamera;
    public Camera firstPerson;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Axis Setup
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Rotate the vehicle left and right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.F))
        {
            firstPerson.enabled = !firstPerson.enabled;
            mainCamera.enabled = !mainCamera.enabled;
        }
    }
}
