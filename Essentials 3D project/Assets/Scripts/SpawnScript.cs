using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpawnScript : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InvokeTest", 1.0f,2.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            CancelInvoke("InvokeTest");
        }
    }

    void InvokeTest()
    {
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}
