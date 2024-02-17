using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoyoController : MonoBehaviour
{
    // Start is called before the first frame update
    public SpringJoint2D joint;
    public float maxdist;

    void Start()
    {
        joint.distance = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        { 
            if (joint.distance < maxdist)
            {
                joint.distance += 0.1f * maxdist * Time.deltaTime;
            }
        }
    }
}
