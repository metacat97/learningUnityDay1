using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SphereMove : MonoBehaviour
{
    //public GameObject target;
    public Rigidbody testrigid = default;
    public float testForce = default;
   
    
    // Start is called before the first frame update
    void Start()
    {
        testrigid = GetComponent<Rigidbody>();    // ���� �ȿ��� Ÿ���� �־���� �� �ʱ�ȭ
        //testrigid.AddForce(Vector3.up * testForce, ForceMode.Impulse);
       
    }

    
    void FixedUpdate()
    {

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    testForce += 1.0f *  Time.deltaTime;
        //    Debug.LogFormat("�� ���̴��� => {0}", testForce);
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    testrigid.AddForce(Vector3.up * testForce, ForceMode.Impulse);
        //}
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
       0.0f, Input.GetAxisRaw("Vertical"));
        testrigid.AddForce(vec*0.5f, ForceMode.Impulse);
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            testrigid.velocity = Vector3.zero; //���������� �ӷ� ������
            testForce = 10.0f;
        }
        else if (Input.GetButton("Jump"))
        {
            testForce += 1.0f * Time.deltaTime;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            testrigid.AddForce(Vector3.up *testForce, ForceMode.Impulse);
            testrigid.velocity = testrigid.velocity * 0.5f;
        }

       

    }

   
}
