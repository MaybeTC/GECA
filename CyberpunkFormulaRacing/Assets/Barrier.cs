using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //
        if(other.name == "CarBodywork")
        {
            Debug.Log(" Boom!");
            Time.timeScale = 0;
        }
        
    }
}
