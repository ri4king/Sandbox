using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{
    public Vector3 StartPoint = new Vector3(200.0f, 200.0f, -1.0f);
    public Vector3 FirstPoint = new Vector3(-250.0f, -250.0f, -1.0f);
    public Vector3 SecondPoint = new Vector3(-150.0f, 150.0f, -1.0f);
    public Vector3 ThirdPoint = new Vector3(200.0f, -200.0f, -1.0f);
    public Vector3 CurrentPoint;
    void Start()
    {
        transform.position = StartPoint;
        CurrentPoint = FirstPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, CurrentPoint, 15.0f *Time.deltaTime);
        if(transform.position == FirstPoint)
            {
                CurrentPoint = SecondPoint;
            }
        else if (transform.position == SecondPoint)
            {
                CurrentPoint = ThirdPoint;
            }
        else if (transform.position == ThirdPoint)
            {
                CurrentPoint = StartPoint;
            }
        else if (transform.position == StartPoint)
            {
                CurrentPoint = FirstPoint;
            }


    }
}
