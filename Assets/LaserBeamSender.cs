using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeamSender : MonoBehaviour
{
    private bool isConnected = true;
    private float maxLaserLenght = 20f;
    LineRenderer laserBeam;

    private void Awake()
    {
        laserBeam = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, maxLaserLenght))
        {
            if (hit.collider.gameObject.CompareTag("Receiver") && !isConnected)
            {
                Debug.Log("Is connected");
                isConnected = true;
            } else if (!hit.collider.gameObject.CompareTag("Receiver") && isConnected)
            {
                Debug.Log("Is disconnected");
                isConnected = false;
            }
            Vector3 laserBeamEnd = hit.point;
            laserBeam.SetPosition(0, transform.position);
            laserBeam.SetPosition(1, laserBeamEnd);
        }
    }
}
