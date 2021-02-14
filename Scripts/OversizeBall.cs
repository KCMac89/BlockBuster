using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OversizeBall : MonoBehaviour
{
    //public GameObject Player;
    

   
    public void Toggle_Changed(bool Oversized)
    {
        GameObject player1 = GameObject.FindGameObjectWithTag("Player");
        if (Oversized == true)
        {
            
            player1.transform.localScale = new Vector3(2, 2, 2);
        }
        else
        {
          
            player1.transform.localScale = new Vector3(1, 1, 1);
        }
           
        
       
       
    }
}
