using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float maxOffset;
    Rigidbody2D rb;

    private void Update()
    {
        SetToMousePos();
        rb = GetComponent<Rigidbody2D>();
    }
    private void SetToMousePos()
    {
        Vector3 p = Input.mousePosition;
        Vector3 currPosition = transform.position;
        Vector3 pos = Camera.main.ScreenToWorldPoint(p);
        print(pos); 
        currPosition.x = Mathf.Clamp(currPosition.x, pos.x - maxOffset, pos.x + maxOffset);
        currPosition.y = pos.y;
        transform.position = currPosition;
    }
}
