using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class layer_script : MonoBehaviour
{
    public KeyCode key;
    Camera cam;
    PostProcessLayer rend;
    bool covered = false;
    void Start()
    {
        //if (name == "left_eye")
        //{
        //    Camera.main.stereoTargetEye = StereoTargetEyeMask.Left;
        //}
        //else
        //{
        //    Camera.main.stereoTargetEye = StereoTargetEyeMask.Right;
        //}
        
        cam = GetComponent<Camera>();
        rend = GetComponent<PostProcessLayer>();
        //cam.cullingMask = 1 << 3;
    }

    
    void Update()
    {
        if (Input.GetKeyUp(key))
        {
            if (!covered)
            {
                //cam.cullingMask = 1 << 6;
                rend.enabled = true;
                covered = true;
                Debug.Log(this.name + "covered");
            }
            else
            {
                //cam.cullingMask = 1 << 6;
                //cam.cullingMask = 1 << 3;
                rend.enabled = false;
                covered = false;
                Debug.Log(this.name + "uncovered");

            }
        }
    }
}
