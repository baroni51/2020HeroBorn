using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player");
        {
            Debug.Log("Player detected give cookie");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.name == "Player");
        {
            Debug.Log("Player left without a cookie");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
