using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{

	public Transform targetTransform;

	// Use this for initialization
	void Start ()
	{
		transform.rotation = Quaternion.Euler (45, 0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = targetTransform.position + new Vector3 (0, 5, -5);
	}
}
