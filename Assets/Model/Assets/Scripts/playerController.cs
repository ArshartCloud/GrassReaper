using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	public Transform system;
	// Use this for initialization
	void Start () {
		system = GameObject.Find ("system").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			system.GetComponent<skill> ().hanbingjian ();
		}
	}
}
