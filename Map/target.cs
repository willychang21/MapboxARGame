using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

    
    void Update()
    {
        Debug.Log("changebefore : " + gameObject.GetComponent<Transform>().position);
        Debug.Log("test = " + transform.position);
        if(Input.GetKey(KeyCode.Keypad3))
        {
            Debug.Log("Keypad3 key was pressed.");
            transform.position = new Vector3(transform.position.x+1,0, transform.position.z);           
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            Debug.Log("Keypad1 key was pressed.");
            transform.position = new Vector3(transform.position.x -1, 0, transform.position.z);
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            Debug.Log("Keypad5 key was pressed.");
            transform.position = new Vector3(transform.position.x , 0, transform.position.z+1);
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            Debug.Log("Keypad2 key was pressed.");
            transform.position = new Vector3(transform.position.x , 0, transform.position.z-1);
        }
    }
}
