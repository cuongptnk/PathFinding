using UnityEngine;
using System.Collections;

public class SampleAgentScript : MonoBehaviour {

	private Transform target;
	public Transform[] targetLocation;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		target = targetLocation [Random.Range (0, 14)];
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);
		if (distance () < 5.0f) {
			Destroy (gameObject);
		}
	}
	float distance(){
		return Vector3.Distance(gameObject.transform.position, target.position);
	}

}
