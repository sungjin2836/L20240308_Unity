using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpehereController : MonoBehaviour
{
    //Ʈ������(Transform)
    //ȸ��, ��ġ, ũ�� ǥ���� ����
    //�θ� - �ڽ� ���Ť� �����ϱ� ���ؼ��� ����
    //���� ������Ʈ���� �׻� �ϳ��� Ʈ������ ������Ʈ�� ����
    //Ʈ�������� ���� ���� ������Ʈ�� ������ �� ����

    //Scale�� 1�� �⺻ ũ��(������Ʈ�� import �� ũ��)�̰�, ��ġ�� �ٶ� ����ϰ� ����
    //scale ���� üũ�� Ǯ ��� ��� �����ϸ� ����� Ȱ��ȭ ��
    //�����س��� x,y,z�� �������� ���� ������Ű�� x,y,z�� ���� �����


    //input.getkey �Է� ��� �߿� �ش� Ű�� ������ ������ ǥ����
    //input.getkeydown : �� Ű�� �Է����� ��(1��)

    Vector3 rotation;

    private void Start()
    {
        rotation = transform.eulerAngles;
        //transform.eulerAngles�� ������Ʈ�� Transform�� Rotation ���� Vector3�� ���·� ��ȯ�ϴ� �ڵ�
        //���Ϸ����� x,y,z�� ����� ��
        //z,y,z�� �������� ���
        //������ : eulerAngles ��ġ�� ���� ������ų ��� ������Ʈ�� 90�� �̻��� ���� �ʰ� ���� ��

        //�ذ�� : ������ ���� �� ���ʹϾ�(Quaternion)���� ���
        //���ʹϾ��� ����Ƽ�� ���Ϸ� ���� ������ ������ ������ �ذ�å���� ����

        //���ʹϾ�(Quaternion) : �����
        //3���� �׷��ȿ��� ȸ���� ǥ���� �� ��� ��� ����Ѵ� ������ ����
        //���ʹϾ��� x,y,z ���Ϳ� w(��Į��)�� ���� ����� ����
        //���������δ� ���ʹϾ��� x,y,z�� w�� ��� ������ ���Ҽ��̸�
        //w(��Į��)�� �Ǽ��� �ش��ϰ� x,y,z�� ����� �ش�

        //��� : ���ʹϾ����� ����� ��� x,y,z���� �� ȸ���ϴ� ���� ����, ���Ϸ��� �ȵ�(��Į�� ���)


    }


    void Update()
    {
        //������Ʈ�� ��ȯ �̵�(Transform)
        //1. ���� ��ġ�� �ٸ� �������� �ʱ�ȭ�� ��ǥ�� �̵��ϴ� ���
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0,0,2) * Time.deltaTime;
        }

        //2. transform.Translate(�̵��� ��ǥ)�� ���� ��ǥ�� �̵��ϴ� ���
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0,0,-2) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-2, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 2, 0) * Time.deltaTime);
            
        }

        //������Ʈ�� ���� ȸ���� ����
        if (Input.GetKey(KeyCode.A))
        {
            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotation);

            //���ʹϾ� ����
            //Quaternion.LookRotation(); //������ upwards ������ rotation�� �����ϴ� �ڵ� ȸ���� ����
            //Quaternion.Euler(rotation); // �� ���� ȸ���� ������� rotation�� ��ȯ�ϴ� ��� / ���Ϸ� ������ ���
            //Quaternion.Angle(a, b); //���ʹϾ� �� a�� b ������ ������ ��ȯ�ϴ� ���
            //Quaternion.Slerp(a,b,t); // a�� b���̸� t�������� ���� ������ -> �ε巯�� �̵�
            //����� ���� Mathf.Lerp(a,b,t) : a�� b���̸� t�������� ���� ������
            //quaternion.Identity : ȸ�� ���� ������ �ǹ���(������Ʈ�� �Ϻ��ϰ� ���� ��ǥ/ �θ��� ������ ����)
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
            //Rotate�� ������Ʈ�� ���� transform�� �־��� ��ġ��ŭ +�ϴ� ����
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
            transform.eulerAngles = rotation; //���Ϸ� ��(���� ����)�� ȸ�� �� �ʱ�ȭ
        }
        if( Input.GetKey(KeyCode.W))
        {
            transform.localScale = new Vector3(2, 2, 2);
            //localScale�� ��ü�� ������ ũ�⸦ �ǹ���
        }
    }
}
