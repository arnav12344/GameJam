using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoyoController : MonoBehaviour
{
    // Start is called before the first frame update
    public SpringJoint2D joint;
    public float maxdist;
    public float mindist;
    public float yoyoUpSpeed;
    bool goUp = false;
    bool goDown = true;
    public SliderScript sliderScript;
    void Start()
    {
        joint.distance = mindist;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Mouse Y") <-0.1f && goDown)
        {
            StopAllCoroutines();
            StartCoroutine(goDownYoyo());
        }
        else if (Input.GetAxisRaw("Mouse Y") > 0.1f && goUp)
        {
            StopAllCoroutines();
            StartCoroutine(goUpYoyo());
            sliderScript.CheckValue();
        }
    }
    IEnumerator goUpYoyo()
    {
        goUp = false;
        Vector3 p = Input.mousePosition;
        Vector3 currPosition = transform.position;
        Vector3 pos = Camera.main.ScreenToWorldPoint(p);
        while (joint.distance >= mindist)
        {
            joint.distance -= joint.distance * Time.deltaTime * yoyoUpSpeed;
            
            yield return null;
        }
        goDown = true;
    }
    IEnumerator goDownYoyo()
    {
        goDown = false;
        Vector3 p = Input.mousePosition;
        Vector3 currPosition = transform.position;
        Vector3 pos = Camera.main.ScreenToWorldPoint(p);
        while (joint.distance <= maxdist)
        {
            joint.distance += joint.distance * Time.deltaTime * yoyoUpSpeed;
            yield return null;
        }
        goUp = true;
    }
}
