using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;

    [SerializeField] private string doorOpen = "DoorOpen"; 

    bool isOpened = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entrer");
        if (other.CompareTag("Objet1"))
        {
            Debug.Log("Player");
            if (openTrigger)
            {
                Debug.Log("Open");
                myDoor.Play("DoorOpen",0,0.0f);
                //myDoor.SetBool("isOpen", true);
                gameObject.SetActive(false);
                //isOpened = true;

                openTrigger = false;
            }
        }
    }
}
