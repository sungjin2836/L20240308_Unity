using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //플레이어에 대한 움직임 처리
    //플레이어가 충돌하는 값에 대한 처리

    //충돌을 고려한다면 Rigidbody 기반의 움직임 코드를 작성하는 것이 좋습니다.
    //만약에 이번 예제처럼 Transform을 통해 움직인다면 플레이어가 아닌 물체에 Rigidbody를 연결

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
