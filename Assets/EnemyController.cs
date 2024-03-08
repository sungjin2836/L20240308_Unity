using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public float speed = 2.0f;
    public float length = 2.0f;

    private float run_time = 0.0f;
    private float PosY = 0.0f;
    private float PosZ = 0.0f;

   // public GameObject obj;
    

    private void Start()
    {
        PosZ = transform.position.z;
    }

    // Update is called once per frame
    private void Update()
    {
        run_time += Time.deltaTime * speed;
        PosY = Mathf.Sin(run_time)*length;
        transform.position = new Vector3 (0, PosY, PosZ);
        //Debug.Log("run_time : " + run_time);
        //Debug.Log("deltaTime : " + Time.deltaTime);
        //Debug.Log("PosY : " + PosY);
    }
}
