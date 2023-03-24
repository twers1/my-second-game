using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("SnakeMain"))
        {
            other.GetComponent<SnakeMovment>().addTail();
            Destroy(gameObject);
        }
    }
}
