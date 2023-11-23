using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room2_trigger : MonoBehaviour
{
    [SerializeField] private bool checkSphere;
    [SerializeField] private bool checkCube;
    [SerializeField] private bool checkPyramid;
    [SerializeField] private room2 roomDatas;

    private void OnTriggerEnter(Collider collision)
    {
        if (checkSphere && collision.CompareTag("Sphere")) { roomDatas.SetSphereCheck(); }
        else if (checkPyramid && collision.CompareTag("Pyramid")) { roomDatas.SetPyramidCheck(); }
        else if (checkCube && collision.CompareTag("Cube")) { roomDatas.SetCubeCheck(); }
    }
}
