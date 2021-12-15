using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    //Setting speed
    public float speed;
    public float turnSpeed = 5;
    public float fallingSpeed = -12;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
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
        
        //Press W key to accelerate
        if(Input.GetKeyDown(KeyCode.W))
        {
            speed = 10;
            return;
        }

        //Press S key to slow down.
        if(Input.GetKeyDown(KeyCode.S))
        {
            speed = 2;
            return;
        }

        //When the car moves off the track
        if(transform.position.x < -4.5 || transform.position.x > 4.5)
        {
            //The car began to fall.
            transform.Translate(0, fallingSpeed * Time.deltaTime, 0);
        }
        
        //After that lose the game.
        if(transform.position.y < -25)
        {
            Debug.Log("You Lose! Press R key to restart the game.");
            Time.timeScale = 0;
        }
    }
}
