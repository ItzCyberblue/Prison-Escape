using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour 
{

	public float speed;
	private float waitTime;
	public float startWaitTime;
	public float startTimeBtwShots;
	public float TimeBtwShots;
	public Transform[] positions;
	private int randPos;
	public GameObject projectile;
	void Start()
	{

		waitTime = startWaitTime;
		randPos = Random.Range(0, positions.Length);

		TimeBtwShots = startTimeBtwShots;


	}

	void Update()
	{

		transform.position = Vector2.MoveTowards(transform.position, positions[randPos].position, speed * Time.deltaTime);

		if(Vector2.Distance(transform.position, positions[randPos].position) < 0.2f)
		{

			if(waitTime <= 0)
			{

				randPos = Random.Range(0, positions.Length);
				waitTime = startWaitTime;

			}
			else
			{

				waitTime -= Time.deltaTime;

			}

			if(TimeBtwShots <= 0){
				
			Instantiate(projectile, transform.position, Quaternion.idenity);
			TimeBtwShots = startTimeBtwShots;

		} else {

			TimeBtwShots -= Time.deltaTime;

		}

	}

}