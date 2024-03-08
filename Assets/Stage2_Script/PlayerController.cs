using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //�÷��̾ ���� ������ ó��
    //�÷��̾ �浹�ϴ� ���� ���� ó��

    //�浹�� ����Ѵٸ� Rigidbody ����� ������ �ڵ带 �ۼ��ϴ� ���� �����ϴ�.
    //���࿡ �̹� ����ó�� Transform�� ���� �����δٸ� �÷��̾ �ƴ� ��ü�� Rigidbody�� ����

    float speed = 2.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position+ new Vector3(0,0,-2) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, 2) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(-2, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(2, 0, 0) * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            int deathCount = PlayerPrefs.GetInt("DeathCount") + 1;
            PlayerPrefs.SetInt("DeathCount", deathCount);
            Debug.Log("deathCount : " + deathCount);
            Debug.Log("PlayerPrefs.DeathCount" + PlayerPrefs.GetInt("DeathCount"));

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }
}
