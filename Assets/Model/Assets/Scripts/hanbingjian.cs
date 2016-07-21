using UnityEngine;
using System.Collections;

public class hanbingjian : MonoBehaviour {
	public Transform system;
	// Use this for initialization
	void Start () {
		system = GameObject.Find ("system").transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("haha");
		system.GetComponent<trigger> ().damage (collision.gameObject, 3);
	}
}
