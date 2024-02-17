using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float maxOffset;

    private void Update()
    {
        Vector3 p = Input.mousePosition;
        Vector3 pos = Camera.main.ScreenToWorldPoint(p);
        if (pos.x > (transform.position.x + maxOffset))
        {
            Vector3 currPosition = transform.position;
            currPosition.x = transform.position.x + maxOffset - pos.x;
            transform.position = currPosition;
        }
        if (pos.x < (transform.position.x - maxOffset))
        {
            Vector3 currPosition = transform.position;
            currPosition.x = transform.position.x - maxOffset - pos.x;
            transform.position = currPosition;
        }
        transform.position = pos;
        Debug.Log(pos);
    }
}
