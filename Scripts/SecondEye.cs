using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
Summary:
This script (added to LeftEyeAnchor) changes the color of left planet, sofas and coffee table in the left eye. This is Binocular diparities - different colors of same objects.
It is tuned by pressing the B button on the right hand controller.
*/

public class SecondEye : MonoBehaviour
{
    Camera cam;                                     // Creating instance of camera.
    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();    //Getting all the components of LeftEyeAnchor Camera.
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))  // On trigger of Button B
        {
            if (cam.cullingMask == -1)              // Checking if the layer 'Default' is enabled, which shows everything normal.
            {
                cam.cullingMask = ~(1 << 7);        // Show everything except GameObjects on layer 'SecondColor'. The layer number is 7. It swithces off the above mentioned objects with original colors and a different color is visible.

            }
            else
            {
                cam.cullingMask |= (1 << 7);        // Switch on GameObjects on layer 8, and leave others as is.
            }

        }
    }
}
