using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector2 mousePosition;
    private float quotient;
    public float delta;
    public float mass;
    
    private Vector2 randVec;
    private Vector3 vecScale;
    int[] levelStructure = new int[20];
    public float CamSize;

    public float level;
   

    void Start()
    {
        CamSize = 10.0f;
        mass = 10;
        delta = 5;
        
        vecScale.Set(0.1f, 0.1f, 0.1f);
        delta = 18 * Mathf.Pow(20, -Mathf.Log(2, 0.1f)) * Mathf.Pow(mass, Mathf.Log(2, 0.1f));
        level = 1.0f;
       
        for (int i=0; i < levelStructure.Length; i++)
        {
            levelStructure[i] += 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition -= (Vector2)transform.position;
        quotient = Mathf.Sqrt(mousePosition.x * mousePosition.x + mousePosition.y * mousePosition.y) / delta;
        mousePosition /= quotient;
        transform.Translate(mousePosition * Time.deltaTime);
        if (mass - (level * 100) >= level)
        {
            if (level < 21)
            {
                level += 1.0f;
                
                transform.localScale += new Vector3(6, 6, 1) * Time.deltaTime;
                CamSize += 2.0f;
                delta += 0.1f;
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Eat(Clone)")
        {
            mass += 5;
            randVec.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
            col.gameObject.transform.position = randVec;
            
        }
        if (col.gameObject.name == "Eat4(Clone)")
        {
            mass += 7;
            randVec.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
            col.gameObject.transform.position = randVec;

        }
        if (col.gameObject.name == "Eat5(Clone)")
        {
            mass += 10;
            randVec.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
            col.gameObject.transform.position = randVec;
        }
        if (col.gameObject.name == "Rocket1")
        {
            if (mass > 200)
            {
                mass += 15;
                randVec.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
                col.gameObject.transform.position = randVec;
            }
        }
        if (col.gameObject.name == "Rocket2")
        {
            if (mass > 700)
            {
                mass += 25;
                randVec.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
                col.gameObject.transform.position = randVec;
            }
        }
        if (col.gameObject.name == "Rocket3")
        {
            if (mass > 800)
            {
                mass += 40;
                randVec.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
                col.gameObject.transform.position = randVec;
            }
        }
        if (col.gameObject.name == "Rocket4")
        {
            if (mass > 800)
            {
                mass += 40;
                randVec.Set(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f));
                col.gameObject.transform.position = randVec;
            }
        }
    }
}
