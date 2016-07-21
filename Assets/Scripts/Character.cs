using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{

	public GameObject weapon;
	private Animator animator;

	// Use this for initialization
	void Start ()
	{
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}


	//TODO

	public void Move (float h, float v)
	{
		animator.SetFloat ("speed", h * h + v * v);
		transform.LookAt (transform.position + new Vector3 (h, 0, v));
	}

	//TODO
	public void Attack ()
	{
		animator.SetBool ("attack2", true);
		weapon.GetComponent<DamageOnContact> ().AttackBegin ();
	}

	public void AttackStop ()
	{
		animator.SetBool ("attack2", false);
		weapon.GetComponent<DamageOnContact> ().AttackEnd ();
	}
}
