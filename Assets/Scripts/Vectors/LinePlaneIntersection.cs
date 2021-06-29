using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePlaneIntersection : MonoBehaviour
{
    public Transform UBegin, UEnd, VBegin, VEnd, WBegin, WEnd;
    public Transform IntersectPointT;

    void Update()
    {
        VBegin.position = UBegin.position;
        float t_w;
        VectorUtils.GetLinePlaneIntersection(UBegin.position, UEnd.position, VEnd.position, WBegin.position, WEnd.position, out t_w);

        IntersectPointT.gameObject.SetActive(true);
        IntersectPointT.position = (WEnd.position - WBegin.position) * t_w + WBegin.position;
    }
}
