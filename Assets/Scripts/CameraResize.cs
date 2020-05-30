using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResize : MonoBehaviour
{
    public Camera camSize;
    private GameObject scriptPlayerController;
    
    
    void Start()
    {
        scriptPlayerController = GameObject.Find("Player");
       
        camSize.orthographicSize = 20.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (scriptPlayerController.GetComponent<PlayerController>().CamSize > camSize.orthographicSize)
        {
            
            camSize.orthographicSize += scriptPlayerController.GetComponent<PlayerController>().CamSize * Time.deltaTime;
        }
    }

   



}
