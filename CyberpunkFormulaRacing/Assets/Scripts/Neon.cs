using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neon : MonoBehaviour
{
    Color colorOne = Color.red;
    Color colorTwo = Color.blue;
    float duration = 1.0f;
    Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = Color.Lerp(colorOne, colorTwo, lerp);
    }
}
