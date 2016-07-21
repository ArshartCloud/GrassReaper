using UnityEngine;
using System.Collections;

public class Frostbolt : ISkill
{

	public	void OnEffect (GameObject A, GameObject B)
	{
		GameController.instence.Damage (A, B, 5);
	}
}
