using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraPositionController : MonoBehaviour
{
    public float cameraSpeed = 1.0f;
    public GameObject player;
    Vector3 vector3;

    private void Start()
    {
        vector3 = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
       transform.position = player.transform.position + vector3;
       // Debug.Log("moveVector3 : " + moveVector3);
        Debug.Log("vector3 : " + vector3);
    }
}
