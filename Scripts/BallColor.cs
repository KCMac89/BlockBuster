using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallColor : MonoBehaviour
{

    public Dropdown dropdown;
    //public Material[] material;
   // public Material PlayerMaterial;
    public Material RedPlayer;
    public Material BluePlayer;
    public Material YellowPlayer;

    public GameObject Player;
   // public GameObject player1 = GameObject.FindGameObjectWithTag("Player");


   
      
    
    //Renderer rend;

     void Start()
    {

     // GameObject player1 = GameObject.FindWithTag("Player");
    /* rend = GetComponent<Renderer>();
     rend.enabled = true;
     rend.sharedMaterial = material[0];*/
}
    

    /*public void ColorChange()
    {
        switch (dropdown.value)
        {
            case 1:
                rend.sharedMaterial = material[0];
                    break;
            case 2:
                rend.sharedMaterial = material[1];
                break;
            case 3:
                rend.sharedMaterial = material[2];
                break;
           
              
        }
    }*/

    public void NewColor()
     {
       
        switch (dropdown.value)
         {
             case 1:
              Player.GetComponent<Renderer>().sharedMaterial = RedPlayer;
                 break;
             case 2:
                Player.GetComponent<Renderer>().material = BluePlayer;
                break;
             case 3:
                Player.GetComponent<Renderer>().material.color = Color.yellow;
                break;
         }


     }

   /* void Update()
    {
        switch (dropdown.value)
        {
            case 1:
                gameObject.GetComponent<Renderer>().material.color = new Color32(0, 255, 0, 128);
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 128);
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 255, 128);
                break;
        }

    }*/

}
