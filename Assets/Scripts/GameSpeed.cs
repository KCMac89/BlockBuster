using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSpeed : MonoBehaviour
{
    public Slider slider;
    public Text sliderText;
   // public float gameSpeed;
   // public float maxSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
       // slider.maxValue = maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = slider.value.ToString("f");
        slider.onValueChanged.AddListener(delegate { ChangeGameSpeed(); });
        //slider.value = Time.timeScale;
    }

    public void ChangeGameSpeed()
    {
        Time.timeScale = slider.value;
    }
   
}
