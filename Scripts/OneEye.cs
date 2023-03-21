using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
Summary:
This script (added to RightEyeAnchor) makes the right planet, cupboard, bed, and Table/Chair dissappear from right eye and only visible in the left eye. This is bad visuals.
It is tuned by pressing the Y button on the left hand controller of the VR.
This is done by showing a layer of objects to the camera on trigger.
*/

public class OneEye : MonoBehaviour
{
    Camera cam;                                     // Creating instance of camera. 

    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();    //Getting all the components of RightEyeAnchor Camera.
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.Y)) // On trigger of Button Y
        {
            if (cam.cullingMask == -1)              // Checking if the layer 'Default' is enabled, which shows everything normal. 
            {
                cam.cullingMask = ~(1 << 8);        // Show everything except GameObjects on layer 'Cube'. The layer number is 8. It swithces off the above mentioned objects.
         
                // Debug.Log(cam.cullingMask);      // Checking the log values when different layers are selected.
            }
            else
            {
                cam.cullingMask |= (1 << 8);        // Switch on GameObjects on layer 8, and leave others as is.
                // Debug.Log(cam.cullingMask);      // Checking the log values when different layers are selected.
            }

        }
    }
}
