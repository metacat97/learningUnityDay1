using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float Speed = default;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // �Է� ���� ����
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //�̵� �Ÿ� �ӵ� ����
        h = h * Speed * Time.deltaTime;
        v = v * Speed *Time.deltaTime;

        //���� �̵�
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);
    }
}
