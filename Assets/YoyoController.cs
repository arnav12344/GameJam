using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoyoController : MonoBehaviour
{
    // Start is called before the first frame update
    public SpringJoint2D joint;
    public float maxdist;
    public float mindist;

    void Start()
    {
        joint.distance = mindist;
    }
    
    // Update is called once per frame
    void Update()
    {
        print(joint.distance);
        if (Input.GetAxis("Mouse Y") > 0)
        { 
            if (joint.distance < maxdist)
            {
                joint.distance += maxdist * Time.deltaTime;
            }
        }
        else if (Input.GetAxis("Mouse Y") < 0)
        {
            if (joint.distance > mindist)
            {
                joint.distance -=  maxdist * Time.deltaTime;
            }
        }
    }
}
