using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour 
{

	public Transform target;

	public float dampSpeed = 0.125f;
	public Vector3 offset;

	void FixedUpdate()
	{

		Vector3 goingTo = target.position + offset;
		Vector3 smoothPos = Vector3.Lerp(transform.position, goingTo, dampSpeed * Time.fixedDeltaTime);
		transform.position = smoothPos;

	}

}