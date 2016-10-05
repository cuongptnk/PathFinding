using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject car;
	public Transform[] iniLocation;
	public int carNum;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < carNum; i++) {
			Transform iniLoc = iniLocation [Random.Range (0, 14)];
			Instantiate(car, iniLoc.position,Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
