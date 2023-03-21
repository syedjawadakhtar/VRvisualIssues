using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Follwing the instructions on Moodle to create a Quit key on pressing Button X.

public class Quit_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
