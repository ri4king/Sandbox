using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMinusMovement : MonoBehaviour
{
    private Vector3 target = new Vector3(5.0f, 0.0f, -1.0f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, -1 * Time.deltaTime);
    }
}
