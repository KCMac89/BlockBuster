using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Dropdown dropdown;
    public static Color BallColor;
    Renderer rend;
    Renderer rend2;

    Color Red = new Color(255, 0, 0);
    Color Blue = new Color(0, 0, 255);
    Color Green = new Color(0, 255, 0);

    public void ColorSwitch()
    {
       switch (dropdown.value)
        {
            default:
                BallColor = Red;
                break;
            case 1:
                BallColor = Red;
                break;
            case 2:
                BallColor = Blue;
                break;
            case 3:
                BallColor = Green;
                break;
           
        }


    }




}
