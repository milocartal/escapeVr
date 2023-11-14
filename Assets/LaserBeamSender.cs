using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeamSender : MonoBehaviour
{
    private float hitDistance = 0f;
    private bool isConnected = true;
    LineRenderer laserBeam;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, 20f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.red);
            if (hit.collider.gameObject.CompareTag("Receiver") && !isConnected)
            {
                Debug.Log("Is connected");
                isConnected = true;
            } else if (!hit.collider.gameObject.CompareTag("Receiver") && isConnected)
            {
                Debug.Log("Is disconnected");
                isConnected = false;
            }
            if (hit.distance != hitDistance)
            {
                hitDistance = hit.distance;
                Debug.Log(hitDistance);
            }
        }
    }
}
