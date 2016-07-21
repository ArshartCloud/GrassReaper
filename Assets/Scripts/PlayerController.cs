using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{

	public ISkill skill;

	// Use this for initialization
	void Start ()
	{
		skill = new Frostbolt () as ISkill;
	}
	
	// Update is called once per frame
	void Update ()
	{
		float h = CrossPlatformInputManager.GetAxis ("Horizontal");
		float v = CrossPlatformInputManager.GetAxis ("Vertical");

		if (CrossPlatformInputManager.GetButtonDown ("Skill1")) {
			Debug.Log ("Player Use Skill 1");
			GetComponent<Character> ().Attack ();
		}

//		if (CrossPlatformInputManager.GetButtonUp ("Skill1")) {
//			Debug.Log ("Player stop Use Skill 1");
//			GetComponent<Character> ().AttackStop ();
//		}

		GetComponent<Character> ().Move (h, v);
	}

	public void UseSkill ()
	{
		skill.OnEffect (gameObject, gameObject);
	}
}
