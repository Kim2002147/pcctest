using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("player"))
        {
            print("Player entered Trigger Area");
        }
    }
     
    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.CompareTag("player"))
        {
            print("Player exit Trigger Area");
        }
    }

    private void OnTriggerStay(Collider other)
    {

    }
}
 