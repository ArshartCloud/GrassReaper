using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public int distance = 10;
	public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = player.position;
		position.y += distance;
		position.x += distance;
		transform.position = position;
		transform.LookAt (player);
	}
}
