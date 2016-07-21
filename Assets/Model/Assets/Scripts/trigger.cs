using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void damage(GameObject obj, int d) {
		Debug.Log (obj.name);
		Destroy (obj, 2);
	}


}
