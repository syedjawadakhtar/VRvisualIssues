using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRightEye : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            transform.position = transform.position + new Vector3(0.0f, 0.0f, 3.0f);
        }
    }
}
