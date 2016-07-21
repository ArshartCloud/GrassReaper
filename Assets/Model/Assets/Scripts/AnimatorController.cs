using UnityEngine;
using System.Collections;

public class AnimatorController : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = transform.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.S)) {
			transform.LookAt (new Vector3 (100000, 0, 0));
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.LookAt (new Vector3 (-100000, 0, 0));
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.LookAt (new Vector3 (0, 0, 100000));
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.LookAt (new Vector3 (0, 0, -100000));
		}


		if (Input.GetMouseButtonDown (0)) {
			animator.SetBool ("attack2", true);
		}
		if (Input.GetMouseButtonUp (0)) {
			animator.SetBool ("attack2", false);
		}
		if (Input.GetMouseButtonDown (1)) {
			animator.SetBool ("attack1", true);
		}
		if (Input.GetMouseButtonUp (1)) {
			animator.SetBool ("attack1", false);
		}


		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		animator.SetFloat ("speed", h * h + v * v);
	}
}
