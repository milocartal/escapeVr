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
<<<<<<< HEAD
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
=======
        if ((other.CompareTag("Objet1")) || (other.CompareTag("Cube")) && (other.CompareTag("Sphere")) && (other.CompareTag("Pyramid")))
        {
            if (openTrigger)
            {
                myDoor.Play("DoorOpen",0,0.0f);
                gameObject.SetActive(false);
>>>>>>> 13286db (changes)
                openTrigger = false;
            }
        }
    }
}
