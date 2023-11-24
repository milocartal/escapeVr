using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SnapToTrigger : MonoBehaviour
{
    private XRGrabInteractable interactable;

    private void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    public void Snap(Vector3 trigger_pos)
    {
        interactable.enabled = false;
        gameObject.transform.position = trigger_pos;    
    }
}