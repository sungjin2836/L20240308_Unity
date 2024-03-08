using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEnemyController : MonoBehaviour
{
    public float speed = 2.0f;
    public float length = 2.0f;

    private float run_time = 0.0f;
    private float PosX = 0.0f;
    private float PosZ = 0.0f;

    public GameObject Object;
    // public GameObject obj;


    private void Start()
    {
        PosZ = Object.transform.position.z;
        Debug.Log(Object.gameObject.name+"PosY의 값은"+PosZ);
        
    }

    // Update is called once per frame
    private void Update()
    {
        run_time += Time.deltaTime * speed;
        PosX = Mathf.Sin(run_time) * length;
        Object.transform.position = new Vector3(PosX, 2, PosZ);
        //Debug.Log(Object.gameObject.name+"는"+PosX);
        //Debug.Log(Object.gameObject.name + "는" + PosY);
        //Debug.Log("run_time : " + run_time);
        //Debug.Log("deltaTime : " + Time.deltaTime);
        //Debug.Log("PosY : " + PosY);
    }
}
