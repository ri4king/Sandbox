using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePlusMovement : MonoBehaviour
{
    private Vector3 target = new Vector3(5.0f, 0.0f, -1.0f);
    void Start()
    {
        //CornerSpeed = Rad / TimePeriod;
        //Sector = CornerSpeed;
    }
    void Update()
    {
        //X = Mathf.Cos(Sector);
        //Z = Mathf.Sin(Sector);
        transform.RotateAround(Vector3.zero, Vector3.forward, 1 * Time.deltaTime);
        //Sector += CornerSpeed;
    }
}
