using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject sphere;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) {
            Debug.Log("object is activate");
            sphere.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("object is activate");
            sphere.SetActive(false);
        }
    }
}
