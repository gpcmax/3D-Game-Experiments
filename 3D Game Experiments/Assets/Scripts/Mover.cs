using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour {

    private Vector3 goal;
    private NavMeshAgent agent;
    public GameObject CameraParent;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;

        goal = transform.position;
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        goal = transform.position + CameraParent.transform.right * Input.GetAxis("Horizontal") + CameraParent.transform.forward * Input.GetAxis("Vertical");
        agent.destination = goal;
	}
}
