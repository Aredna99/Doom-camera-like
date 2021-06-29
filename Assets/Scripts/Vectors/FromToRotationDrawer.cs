using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromToRotationDrawer : MonoBehaviour
{
    public Transform ToDir, O;
    public Transform ObjToRotate;
    public bool UseTransformForward = false;
    Quaternion q;
    float angle;
    Vector3 axis;

    void Update()
    {

        Debug.DrawLine(O.position, ToDir.position, Color.green);

        q.ToAngleAxis(out angle, out axis);
        Debug.DrawLine(O.position, axis*5, Color.yellow);
        Debug.Log("ToAngleAxis angle: "+ angle);

        if (!UseTransformForward)
        {
            //Using a fixed vector
            q = Quaternion.FromToRotation(Vector3.forward, ToDir.position);
            Debug.DrawLine(O.position, O.position + Vector3.forward, Color.red);
        }
        else
        {
            //Using transform.forward
            Debug.DrawLine(O.position, O.position + transform.forward, Color.red);
            q = Quaternion.FromToRotation(transform.forward, ToDir.position);
        }


        ObjToRotate.rotation = q;
    }
}
