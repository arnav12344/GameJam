using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public float valueSpeed;
    public Slider slider;
    public float maxValue;
    public float minValue;
    private void Update()
    {
        slider.value = slider.value % 100;
    }

    public void CheckValue()
    {
        if(minValue > slider.value && maxValue < slider.value)
        {
            Debug.Log("you can continue");
        }
        else
        {
            //Loose thing
        }
    }
}
