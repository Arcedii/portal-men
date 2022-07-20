using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    public bool dist;
    public bool look;

    public GameObject[] points;
    public GameObject point;
    public float timer; 
    public int number;
    public bool def;
    public bool agr;

    void Update()
    {
        if (def == true)
        {


            if (timer < 10)
            {
                timer += Time.deltaTime;
            }
            else
            {
                number = Random.Range(0, 10);
                point = points[number];
                timer = 0;
            }
            gameObject.transform.position = point.transform.position;
        }
       

        NavMeshHit hit;

        if (!agent.Raycast(player.transform.position, out hit))
        {
            look = true;
        }
        if (Vector3.Distance(gameObject.transform.position, player.transform.position)<50)
        {
            dist = true;
            def = false;
        }
        else
        {
            dist = false;
        }
       
        if (dist == false)
        {
            look = false;
        }
        if(dist == true && look == true)
        {
            agr = true;
        }
        else
        {
            agr = false;
        }
        if(agr == true)
        {
            agent.SetDestination(player.position);
        }
        if(agr == false)
        {
            def = true;
        }
    }
}
