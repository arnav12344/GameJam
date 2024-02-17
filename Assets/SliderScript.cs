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
    public float currValue = 0;
    private void Update()
    {
        currValue += valueSpeed * Time.deltaTime;

        slider.value = currValue % 100;
        if(Mathf.Floor(currValue/ 100) % 2 == 0)
        {
            slider.value = 100 - currValue % 100;
        }
        else
        {
            slider.value = currValue % 100;
        }
        print(slider.value);
    }

    public void CheckValue()
    {
        if(minValue > slider.value && maxValue < slider.value)
        {
            Debug.Log("you can continue");
            CameraShake.instance.ShakeSmall();
        }
        else
        {
            StartCoroutine(CameraShake.instance.Shake(3, 2f));
        }
    }
}
