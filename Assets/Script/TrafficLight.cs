using UnityEngine;
using System.Collections;

public class TrafficLight : MonoBehaviour {
	public GameObject[] verticalDirection;
	public GameObject[] horizontalDirection;
	private float timeLeft = 5f;
	private bool switchLight = false;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < verticalDirection.Length; i++) {
			verticalDirection [i].SetActive (!switchLight);
		}
		for (int i = 0; i < horizontalDirection.Length; i++) {
			horizontalDirection [i].SetActive (switchLight);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0f) {
			timeLeft = 5f;
			switchLight = !switchLight;

			for (int i = 0; i < verticalDirection.Length; i++) {
				verticalDirection [i].SetActive (!switchLight);
			}
			for (int i = 0; i < horizontalDirection.Length; i++) {
				horizontalDirection [i].SetActive (switchLight);
			}
		}
	}
}
