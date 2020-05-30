using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject eat, eat1, eat2, eat3, eat4, eat5;
    private Vector2 randVector;
    private Vector2 randVector2;
    Random rnd = new Random();




   
    void Start()
    {
        int minrnd = Random.Range(-500, 500);
        for (int i = 0; i < 1000; i++)
        {
            randVector2.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
            Instantiate(eat, randVector2, Quaternion.identity);
        }
        /*for (int i = 0; i < 1000; i++) // Little Meteor rain
        {
            randVector.Set(Random.Range(1000.0f, 1000.0f), Random.Range(-1000.0f, 1000.0f));
            Instantiate(eat1, randVector, Quaternion.identity);
        }*/     //
        for (int i = 0; i < 1000; i++)
        {
            randVector2.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
            Instantiate(eat5, randVector2, Quaternion.identity);
        }
        // int minrnd = Random.Range(-750, 750);
        //int minrnd2 = Random.Range(-750, 750);
        //int minrnd3 = Random.Range(-750, 750);

        /*for (int i = 0; i < 200; i++)
        {
            randVector.Set(Random.Range(minrnd, (minrnd + 20.0f)), Random.Range(minrnd, (minrnd + 250.0f)));
            Instantiate(eat1, randVector, Quaternion.identity);
        }
        for (int i = 0; i < 400; i++)
        {
            randVector.Set(Random.Range(minrnd2, (minrnd2 + 20.0f)), Random.Range(minrnd2, (minrnd2 + 250.0f)));
            Instantiate(eat2, randVector, Quaternion.identity);
        }
        for (int i = 0; i < 200; i++)
        {
            randVector.Set(Random.Range(minrnd3, (minrnd3 + 20.0f)), Random.Range(minrnd3, (minrnd3 + 250.0f)));
            Instantiate(eat3, randVector, Quaternion.identity);
        }*/
        for (int i = 0; i < 200; i++)
        {
            int minrnd4 = Random.Range(900, 1000);
            randVector.Set(Random.Range(minrnd4, (minrnd4 + 20.0f)), Random.Range(minrnd4, (minrnd4 + 250.0f)));
            Instantiate(eat4, randVector, Quaternion.identity);
        }
    }

}
