using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour
{
	void Start ()
	{
		transform.LookAt (new Vector3 (0, 0, -10000));
	}

	// Update is called once per frame
	void Update ()
	{
		//        transform.LookAt(Camera.main.transform);
		transform.LookAt (new Vector3 (0, 0, -10000));
	}
}
