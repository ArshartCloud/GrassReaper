using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public Skill skill;

	// Use this for initialization
	void Start ()
	{
		skill = new Frostbolt () as Skill;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void UseSkill ()
	{
		skill.OnEffect (gameObject, gameObject);
	}
}
