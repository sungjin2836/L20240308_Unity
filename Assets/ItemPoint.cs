using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemPoint : MonoBehaviour
{
    public TextMeshProUGUI ItemCount;
    public TextMeshProUGUI DeathCount;
    public TextMeshProUGUI StageStair;
    public int item;
    public int death;
    void Start()
    {
        
        death = PlayerPrefs.GetInt("DeathCount");
        ItemCount.text = "Item : " + item + "/1";
        DeathCount.text = "DeathCount : " + death;
        StageStair.text = "Stage 1/5";
    }

    // Update is called once per frame
    void Update()
    {
        ItemCount.text = "Item : " + PlayerPrefs.GetInt("ItemCount") + "/1";
        DeathCount.text = "DeathCount : " + death;
        StageStair.text = "Stage 1/5";
    }

    
}

