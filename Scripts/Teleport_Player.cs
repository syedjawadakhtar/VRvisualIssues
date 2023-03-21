using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Was being used for teleporting the player to another plane. But it didn't work.

public class Teleport_Player : MonoBehaviour
{
    // Start is called before the first frame update
    private OVRCameraRig overCameraRig;
    private Vector3 Position;

    void Start()
    {
        
        Position = overCameraRig.centerEyeAnchor.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Position);
        //if (OVRInput.GetDown(OVRInput.Button.One))
        //{
            //    if (Position == new Vector3(2.0f, 8.0f, -6.0f))
            //    {
            //        transform.position = transform.position + new Vector3(14.0f, 8.0f, -10.0f);
            //    }
            //    else
            //        transform.position = transform.position - new Vector3(14.0f, 8.0f, -10.0f);
            //transform.position = transform.position + new Vector3(16.0f, 16.0f, -16.0f);
        //}

       

    }
}
