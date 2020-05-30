using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{

    private Vector2 randVec;

    private Vector2 randVec2;

    private Vector2 randVec3;

    private Vector2 randVec4;
   
    readonly int minrnd3 = Random.Range(900, 1200);
    void OnTriggerEnter2D(Collider2D col)
            
    {

        if (col.gameObject.name == "Eat(Clone)")
        {

            
            randVec.Set(Random.Range(-1000.0f, 1000.0f), Random.Range(-1000.0f, 1000.0f));
            col.gameObject.transform.position = randVec;

        }
        if (col.gameObject.name == "Eat1(Clone)")
        {

            randVec.Set(Random.Range(-1000.0f, 1000.0f), Random.Range(-1000.0f, 1000.0f));
            col.gameObject.transform.position = randVec;

        }
        if (col.gameObject.name == "Eat2(Clone)")
        {

           
            randVec2.Set(Random.Range(-1000.0f, 1000.0f), Random.Range(-1000.0f, 1000.0f));
            col.gameObject.transform.position = randVec2;

        }
        if (col.gameObject.name == "Eat3(Clone)")
        {

            randVec3.Set(Random.Range(-1000.0f, 1000.0f), Random.Range(-1000.0f, 1000.0f));
            col.gameObject.transform.position = randVec3;

        }
        if (col.gameObject.name == "Eat4(Clone)")
        {
            int minrnd4 = Random.Range(minrnd3, (minrnd3+100));

            randVec4.Set(Random.Range(minrnd4, (minrnd4 + 40.0f)), Random.Range(minrnd4, (minrnd4 + 150.0f)));
            col.gameObject.transform.position = randVec4;

        }
    }
}
