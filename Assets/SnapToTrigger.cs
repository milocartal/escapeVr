using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToTrigger : MonoBehaviour
{
    public void Snap(Vector3 trigger_pos)
    {
        gameObject.transform.position = trigger_pos;    
    }
}