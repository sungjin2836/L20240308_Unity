using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    //블록 생성기
    [Header("블록 개수 설정")]
    public int X_BlockCount;
    public int Y_BlockCount;
    [Header("블록 생성 간격")]
    public int Xgap;
    public int Ygap;
    [Header("생성할 블록에 대한 정보")]
    public GameObject[] BlockPrefab;

    //1. 블록에 대한 배열을 만들어줍니다.
    [Header("==블록 리스트 ==")]
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
        //전달받은 배열의 개수만큼 반복을 진행함
        for(int i = 0; i < _Blocks.Length; i++)
        {
            _Blocks[i] = Instantiate(BlockPrefab[0]); // 0번은 x블록
            _Blocks[i].transform.position = new Vector3(-4.36f, 1, X_BlockCount - xgap * i);
            //간격에 맞게 z축이 다르게 설정(각각의 블록을)

            //가지고 있는 블록이 x냐 y냐에 따라 범위 설정
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
