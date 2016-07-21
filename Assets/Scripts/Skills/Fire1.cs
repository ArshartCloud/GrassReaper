using UnityEngine;
using System.Collections;

public class Fire1 : ISkill, ISkillHitTarget
{
	public int baseDamage = 20;
	//	public GameObject fireball;
	public GameObject source;

	public void OnEffect (GameObject A, GameObject B)
	{
		source = A;
		A.GetComponent<Animator> ().SetBool ("Fire1", true);
		GameObject fire1 = Resources.Load ("Prefabs/Skills/Fireball", typeof(GameObject)) as GameObject;
		Debug.Log (fire1);
		GameObject fireball = GameObject.Instantiate (fire1, A.GetComponent<PlayerController> ().spellSpanw.position, A.GetComponent<PlayerController> ().spellSpanw.rotation) as GameObject;
		fireball.GetComponent<FireballCollider> ().source = this as ISkillHitTarget;
	}

	public void OnSkillHitTarget (GameObject target)
	{
		GameController.instence.Damage (source, target, baseDamage);
	}
}
