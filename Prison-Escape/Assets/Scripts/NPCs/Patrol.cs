using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour 
{

	public float speed;
	private float waitTime;
	public float startWaitTime;

	public Transform[] positions;
	private int randPos;

	void Start()
	{

		waitTime = startWaitTime;
		randPos = Random.Range(0, positions.Length);

	}

	void Update()
	{

		transform.position = Vector2.MoveTowards(transform.position, positions[randPos].position, speed * Time.deltaTime);

		if(Vector2.Distance(transform.position, positions[randPos].position) < 0.2f)
		{

			if(waitTime <= 0)
			{

				randPos = Random.Range(0, positions.Length);
				Debug.Log("Chosen Spot: " + randPos);
				waitTime = startWaitTime;

			}
			else
			{

				waitTime -= Time.deltaTime;

			}

		}

	}

}