using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalArea : MonoBehaviour
{
    public static bool goal;

    void Start()
    {
        goal = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            goal = true;
            Debug.Log("���� ���������� �̵�");

            SceneManager.LoadScene("Stage2");
        }

    }
}
