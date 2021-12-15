using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //Setting speed
    public float speed = 15;
    public float turnSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get left and right input of keyboard
        float x = Input.GetAxis("Horizontal");
        //Using Time.deltaTime to control the speed can be independent of the frame rate of the device.
        transform.Translate(x * turnSpeed * Time.deltaTime,0,speed * Time.deltaTime);
    }
}
