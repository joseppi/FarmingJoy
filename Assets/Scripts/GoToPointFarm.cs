using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToPointFarm: MonoBehaviour {

    public GameObject point_farm;
    public NavMeshAgent navMeshAgent;
	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        navMeshAgent.destination = point_farm.transform.position;
        
    }
}
