using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    //��� ������
    [Header("��� ���� ����")]
    public int X_BlockCount;
    public int Y_BlockCount;
    [Header("��� ���� ����")]
    public int Xgap;
    public int Ygap;
    [Header("������ ��Ͽ� ���� ����")]
    public GameObject[] BlockPrefab;

    //1. ��Ͽ� ���� �迭�� ������ݴϴ�.
    [Header("==��� ����Ʈ ==")]
    public GameObject[] X_Blocks;
    public GameObject[] Y_Blocks;
    
    void Start()
    {

        X_Blocks = new GameObject[X_BlockCount];
        Y_Blocks = new GameObject[Y_BlockCount];

        SetBlock(X_Blocks, Xgap, 0);
        SetBlock(Y_Blocks, Ygap, 0);
    }

    private void SetBlock(GameObject[] _Blocks, int xgap, int idx)
    {
        //���޹��� �迭�� ������ŭ �ݺ��� ������
        for(int i = 0; i < _Blocks.Length; i++)
        {
            _Blocks[i] = Instantiate(BlockPrefab[0]); // 0���� x���
            _Blocks[i].transform.position = new Vector3(-4.36f, 1, X_BlockCount - xgap * i);
            //���ݿ� �°� z���� �ٸ��� ����(������ �����)

            //������ �ִ� ����� x�� y�Ŀ� ���� ���� ����
            if (_Blocks[i].GetComponent<BlockMovement>().Position == Position.X_Block)
            {
                _Blocks[i].GetComponent<BlockMovement>().length = 5;
                if(i%2 == 1)
                {
                    _Blocks[i].GetComponent<BlockMovement>().flipx = true;
                }
            }

            if (_Blocks[i].GetComponent<BlockMovement>().Position == Position.Y_Block)
            {
                _Blocks[i].GetComponent<BlockMovement>().length = 3;
            }
        }
    }
}
