using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 50.0f;
    GameObject target2;
    GameObject target3;
    // Start is called before the first frame update
    void Start()
    {
        target2 = GameObject.Find("Cube2");
        target3 = GameObject.Find("Cube3");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.one * speed * Time.deltaTime);
            target2.transform.Rotate(Vector3.one * speed * Time.deltaTime);
            target3.transform.Rotate(Vector3.one * speed * Time.deltaTime);
        }
       
    }
}
