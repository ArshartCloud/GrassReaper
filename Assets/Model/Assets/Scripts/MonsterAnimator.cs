using UnityEngine;
using System.Collections;

public class MonsterAnimator : MonoBehaviour {
	public Transform player;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (transform.position, player.position);
		if (distance <= 2f) {
			animator.SetBool ("attack", true);
		} else if (distance <= 20f) {
			transform.LookAt (player);
			animator.SetBool ("attack", false);
			animator.SetBool ("run", true);
		} else {
			animator.SetBool ("run", false);
			int rand = UnityEngine.Random.Range (0, 120);
			if (rand == 20) {
				animator.SetBool ("walk", true);
			} else if (rand == 40) {
				animator.SetBool ("walk", false);
			}
		}
	}
}
