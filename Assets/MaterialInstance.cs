using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInstance : MonoBehaviour
{

    //���͸����� ������ �޽� ������
    private MeshRenderer m_MeshRenderer;


    //������ ��
    [SerializeField]
    private Color _color;

    
    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>();
        //����� ������
        m_MeshRenderer.material = Instantiate(m_MeshRenderer.material);
        //������ ��Ƽ������ Instanctiate�� ������(����)
        m_MeshRenderer.material.color = _color;
        //��Ƽ������ ���� ������ ������ ������
    }

    void Update()
    {
        
    }
}
