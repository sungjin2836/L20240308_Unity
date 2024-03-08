using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{

    int item;

    public GameObject Block;

    private void Start()
    {
        PlayerPrefs.SetInt("ItemCount", 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (gameObject.activeSelf && collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Debug.Log("아이템 사라짐");

            item = PlayerPrefs.GetInt("ItemCount");
            item++;
            PlayerPrefs.SetInt("ItemCount", item);

            Block.SetActive(false);

        }
    }
}
