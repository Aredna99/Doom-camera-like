using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSelector : MonoBehaviour
{
	public Camera cam;
    Vector3 targetDirection;
    float angle;
    float spriteAngle;
    Transform tmpSprite;

    private void Start()
    {
        for (int i = 0; i < transform.GetChild(0).childCount; i++)
        {
            transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        tmpSprite = transform.GetChild(0).GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        targetDirection = cam.transform.position - transform.position;
        //angle = Vector3.Dot(targetDirection, transform.forward);
        angle = Mathf.Atan2(targetDirection.z, targetDirection.x) * Mathf.Rad2Deg;
        spriteAngle = transform.GetChild(0).transform.rotation.eulerAngles.y;

        if (angle >= 67.5f && angle < 112.5f)//1
        {
            Debug.Log("1");
            transform.GetChild(0).GetChild(7).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
            tmpSprite = transform.GetChild(0).GetChild(0);
        }
        else if (angle > 22.5f && angle < 67.5)//2
        {
            Debug.Log("2");
            transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
            tmpSprite = transform.GetChild(0).GetChild(1);
        }
        else if (angle >= -22.5f && angle < 22.5f)//3
        {
            Debug.Log("3");
            transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
            tmpSprite = transform.GetChild(0).GetChild(2);
        }
        else if (angle >= -67.5f && angle < -22.5f)//4
        {
            Debug.Log("4");
            transform.GetChild(0).GetChild(2).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(3).gameObject.SetActive(true);
            tmpSprite = transform.GetChild(0).GetChild(3);
        }
        else if (angle >= -112.5f && angle < -67.5f)//8
        {
            Debug.Log("5");
            transform.GetChild(0).GetChild(3).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(4).gameObject.SetActive(true);
            tmpSprite = transform.GetChild(0).GetChild(4);
        }
        else if (angle >= -157.5f && angle < -112.5f)//7
        {
            Debug.Log("6");
            transform.GetChild(0).GetChild(4).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(5).gameObject.SetActive(true);
            tmpSprite = transform.GetChild(0).GetChild(5);
        }
        else if (angle < -157.5 || angle > 157.5f)//6
        {
            Debug.Log("7");
            Debug.Log(angle);
            transform.GetChild(0).GetChild(5).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(6).gameObject.SetActive(true);
            tmpSprite = transform.GetChild(0).GetChild(6);
        }
        else if (angle >= 112.5f && angle < 157.5f)//5
        {
            Debug.Log(angle);

            Debug.Log("8");
            transform.GetChild(0).GetChild(6).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(7).gameObject.SetActive(true);
            tmpSprite = transform.GetChild(0).GetChild(7);
        }
    }
}
