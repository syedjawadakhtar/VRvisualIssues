using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Following the Unity Tutorial to change lights as shown in Moodle.

public class Light_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Light _light;
    private Color newColor, wColor;
    void Start()
    {
        _light = GetComponent<Light>();
        newColor = new Color(0.0f, 1.0f, 1.0f, 1.0f);
        wColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);


    }

    // Update is called once per frame
    void Update()
    {
        //if (OVRInput.GetDown(OVRInput.RawButton.Y))
        //{
        //    if (_light.color != newColor)
        //        _light.color = newColor;
        //    else
        //        _light.color = wColor;
        //}
    }
}
