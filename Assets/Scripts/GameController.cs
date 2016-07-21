using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	static public GameController instence;

	// Use this for initialization
	void Start ()
	{
		instence = this;
	}

	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Damage (GameObject A, GameObject B, int damage)
	{
		Debug.Log (B);
		Debug.Log (A.name + " deals " + damage.ToString () + " damage to " + B.name);
		Health health = B.GetComponent<Health> ();
		if (health != null)
			B.GetComponent<Health> ().TakeDamage (damage);
	}
}
