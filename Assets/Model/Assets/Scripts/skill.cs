using UnityEngine;
using System.Collections;

public class skill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void hanbingjian() {
		var obj = GameObject.Instantiate (Resources.Load ("hanbingjian")) as GameObject;

		//obj.transform.Translate()
	}
}
