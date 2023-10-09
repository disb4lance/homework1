using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject sphere;

    public void ButtonPressed() {
        if (sphere.active == false) {
            Debug.Log("object is deactivate");
        }
        if (sphere.active == true)
        {
            Debug.Log("object is activate");
        }
    }
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        
    }
}
