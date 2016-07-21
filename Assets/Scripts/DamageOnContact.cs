using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DamageOnContact : MonoBehaviour
{
	public GameObject source;
	public bool CanDamage = false;
	public int baseDamage = 20;

	public List<GameObject> attacked = new List<GameObject> ();
	//	public ArrayLis attacked = new ArrayList();

	public void AttackBegin ()
	{
		CanDamage = true;
		Debug.Log ("Attack Begins!");
	}

	public	void AttackEnd ()
	{
		CanDamage = false;
		attacked.Clear ();
		Debug.Log ("Attack End~");
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == source || CanDamage == false)
			return;
		
		if (attacked.Exists (delegate(GameObject obj) {
			return obj == other.gameObject;
		})) {
			Debug.Log ("Already attacked.");
		} else {
			GameController.instence.Damage (source, other.gameObject, baseDamage);
			Debug.Log ("attacke obj");
			attacked.Add (other.gameObject);
		}
	}
}
