using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entrer");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player");
            if (openTrigger)
            {
                Debug.Log("Open");
                //myDoor.Play("DoorOpen",0,0.0f);
                myDoor.SetBool("isOpen", true);
                //gameObject.SetActive(false);
            }
        }
    }
}
