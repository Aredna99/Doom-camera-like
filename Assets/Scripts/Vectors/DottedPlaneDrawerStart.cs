using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DottedPlaneDrawerStart : MonoBehaviour
{
    public Transform StartU, EndU, StartV, EndV;
    public GameObject DotPrefab;
    public int Resolution = 10;

    void Start()
    {
        StartU.position = StartV.position;

        //Draw Resolution columns and Resolution rows in the plane defined by U and V vectors

    }
}
