using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject manipulator;
    void Start()
    {
        manipulator = GameObject.Find("Manipulator");
    }

    // Update is called once per frame
    void Update()
    {
        float avgY = manipulator.transform.position.y / 2;
        transform.position = new Vector3(0, avgY + 5, -10);
        GetComponent<Camera>().orthographicSize = avgY + 3;
    }
}

