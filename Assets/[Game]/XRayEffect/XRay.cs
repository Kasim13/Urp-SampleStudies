using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class XRay : MonoBehaviour
{
    Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        var cameraData = cam.GetUniversalAdditionalCameraData();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cameraData.SetRenderer(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cameraData.SetRenderer(1);
        }
    }
}
