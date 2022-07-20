using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    public GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    [SerializeField]
    public float speed;
    float WPradius = 1;
   


    void Update()
    {      
        transform.LookAt(target);
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)     
        {        
            current++;
            if (current >= waypoints.Length)
            {                
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);     
    }

}

