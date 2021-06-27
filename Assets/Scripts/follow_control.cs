using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class follow_control : MonoBehaviour
{
    public GameObject eyeTracker;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 newPos = eyeTracker.GetComponent<Transform>().position;
    }
}
