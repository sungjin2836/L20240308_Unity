using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//블럭이 움직일 패턴을 표현하기 위해 Enum 활용
public enum Position
{
    X_Block, Y_Block
}

public class BlockMovement : MonoBehaviour
{

    public Position Position; //블록의 위치에 대한 표현

    public bool flipx; //x 축 방향 반전

    [Range(1, 5)] public float speed;//블록의 속
    public float length;//  블록의 이동 범위도

    private float run_time;
    public float Pos;



    private void MoveX()
    {
        run_time += Time.deltaTime * speed;
        Pos = Mathf.Sin(run_time) * length;

        if(!flipx)
        {
            transform.position = new Vector3(Pos, gameObject.transform.position.y,
                gameObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(Pos, gameObject.transform.position.y,
                gameObject.transform.position.z);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
