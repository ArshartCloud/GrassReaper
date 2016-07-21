using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{

	public ISkill skill;
	public Transform spellSpanw;

	// Use this for initialization
	void Start ()
	{
		skill = new Fire1 () as ISkill;
	}
	
	// Update is called once per frame
	void Update ()
	{
		float h = CrossPlatformInputManager.GetAxis ("Horizontal");
		float v = CrossPlatformInputManager.GetAxis ("Vertical");

		if (CrossPlatformInputManager.GetButtonDown ("Skill1")) {
			Debug.Log ("Player Use Skill 1");
			UseSkill1 ();
		} else if (CrossPlatformInputManager.GetButtonDown ("Skill2")) {
			UseSkill2 ();
		} else if (CrossPlatformInputManager.GetButtonDown ("Skill3")) {
			UseSkill3 ();
		} else if (CrossPlatformInputManager.GetButtonDown ("NormalAttack")) {
			GetComponent<Character> ().Attack ();
		}

//		if (CrossPlatformInputManager.GetButtonUp ("Skill1")) {
//			Debug.Log ("Player stop Use Skill 1");
//			GetComponent<Character> ().AttackStop ();
//		}

		GetComponent<Character> ().Move (h, v);
	}

	public void UseSkill1 ()
	{
		skill.OnEffect (gameObject, gameObject);
	}

	public void UseSkill2 ()
	{
	}

	public void UseSkill3 ()
	{
	}
}
