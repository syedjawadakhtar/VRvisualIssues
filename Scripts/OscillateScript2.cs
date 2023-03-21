using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to oscillate planet 4 (Venus)/planet 4 (1) Jupiter).


public class OscillateScript2 : MonoBehaviour
{
    private Vector3 pointA = new Vector3(-5.75f, 7.5f, 4.0f);   //Setting two point coordinates between which it will oscillate.
    private Vector3 pointB = new Vector3(-5.75f, 7.5f, -4.0f);  
    private float speed = 0.75f;                                //Speed with which the planet will oscillate.
    private float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;                            // Time adding with speed
        // Moves the object to target position
        transform.position = Vector3.Lerp(pointA, pointB, t);   //Lerp function takes the initial and final coordinates along with the updated time to transform the motion of the planet.
        // Flip the points once it has reached the target
        if (t >= 1)                                             // Making the planet go back to it's position. Hence oscillating.
        {
            var b = pointB;
            var a = pointA;
            pointA = b;
            pointB = a;
            t = 0;
        }
    }
}
