using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInstance : MonoBehaviour
{

    //머터리얼을 적용할 메쉬 렌더러
    private MeshRenderer m_MeshRenderer;


    //변경할 색
    [SerializeField]
    private Color _color;

    
    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>();
        //기능을 가져옴
        m_MeshRenderer.material = Instantiate(m_MeshRenderer.material);
        //가져온 머티리얼을 Instanctiate로 생성함(복제)
        m_MeshRenderer.material.color = _color;
        //머티리얼의 색을 설정한 색으로 변경함
    }

    void Update()
    {
        
    }
}
