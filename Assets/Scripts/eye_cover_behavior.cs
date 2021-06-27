using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eye_cover_behavior : MonoBehaviour
{
    public KeyCode on;
    public KeyCode off;

    private Renderer rend;

    private bool rendered = false;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(off))
        {
            rend.enabled = false;
        }
        else if (Input.GetKeyUp(on))
        {
            if (!rendered)
            {
                rend.enabled = true;
                rendered = true;
            }
            else
            {
                rend.enabled = false;
                rendered = false;
            }
        }
    }
}
