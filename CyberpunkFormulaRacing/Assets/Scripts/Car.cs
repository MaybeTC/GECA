using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    //Setting speed
    public float speed = 15;
    public float turnSpeed = 5;
    public float fallingSpeed = -12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            return;
        }

        //Get left and right input of keyboard
        float x = Input.GetAxis("Horizontal");
        //Using Time.deltaTime to control the speed can be independent of the frame rate of the device.
        transform.Translate(x * turnSpeed * Time.deltaTime, 0, speed * Time.deltaTime);

        //
        if(transform.position.x < -4.5 || transform.position.x > 4.5)
        {
            transform.Translate(0, fallingSpeed * Time.deltaTime, 0);
        }
        //
        if(transform.position.y < -25)
        {
            Debug.Log("You Lose! Press R key to restart the game.");
            Time.timeScale = 0;
        }
    }
}
