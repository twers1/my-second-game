using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tailMovment : MonoBehaviour
{

    public float Speed;


    public Vector3 tailTarget;

    public int index;

    public GameObject tailTargetObj;

    public SnakeMovment mainSnake;
    
    void Start()
    {
         
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovment>();
        Speed =  mainSnake.Speed+1.5f;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
        index = mainSnake.tailObjects.IndexOf(gameObject);
    }

    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime*Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if(index> 2)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

  
}
