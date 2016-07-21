using UnityEngine;
using System.Collections;

public class FireballCollider : MonoBehaviour
{
	public ISkillHitTarget source;

	void OnParticleCollision (GameObject other)
	{
//		Debug.Log ("Boom!");
		source.OnSkillHitTarget (other);
	}
}
