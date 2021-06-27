using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_script : MonoBehaviour
{
    public GameObject follow;
    private Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = follow.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(pos.position.x, pos.position.y, -2.727f);
    }
}
