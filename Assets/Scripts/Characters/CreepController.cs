using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CreepController : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject finalTarget;


    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
