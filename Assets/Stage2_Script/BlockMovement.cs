using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ������ ������ ǥ���ϱ� ���� Enum Ȱ��
public enum Position
{
    X_Block, Y_Block
}

public class BlockMovement : MonoBehaviour
{

    public Position Position; //����� ��ġ�� ���� ǥ��

    public bool flipx; //x �� ���� ����

    [Range(1, 5)] public float speed;//����� ��
    public float length;//  ����� �̵� ������

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
