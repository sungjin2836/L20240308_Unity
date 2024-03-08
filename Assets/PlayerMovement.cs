using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [InitializeOnLoadMethod]
    static void DeathCount()
    {
        PlayerPrefs.SetInt("DeathCount", 0);
        Debug.Log("deathCount : " + PlayerPrefs.GetInt("Deathcount"));

    }
    
    void Start()
    {
        //if(PlayerPrefs.GetInt("DeathCount").ToString() == null)
        //{
        //    PlayerPrefs.SetInt("DeathCount", 0);
        //}
        ////
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, - 0.1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(0.1f, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            int deathCount = PlayerPrefs.GetInt("DeathCount")+1;
            PlayerPrefs.SetInt("DeathCount", deathCount);
            Debug.Log("deathCount : " + deathCount);
            Debug.Log("PlayerPrefs.DeathCount"+PlayerPrefs.GetInt("DeathCount"));

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }







}
