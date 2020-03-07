using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour {
	public Transform target;

	public float speed = 200f;
	public float distanceToNextPoint = 3f;

	Path path;
	int currentPoint = 0;
	bool reachedEndOfPath = false;

	Seeker seeker;
	Rigidbody2D rb;

	void Start()
	{
		seeker = this.GetComponent<Seeker>();
		rb = this.GetComponent<Rigidbody2D>();

		InvokeRepeating("UpdatePath", 0f, 0.5f);
	}

	void UpdatePath()
	{
		if(seeker.IsDone())
		{
			seeker.StartPath(rb.position, target.position, OnPathComplete);
		}
	}

	void OnPathComplete(Path p)
	{
		if(!p.error)
		{
			path = p;
		}
	}

	void FixedUpdate()
	{
		if(path == null)
		{
			return;
		}

		if(currentPoint >= path.vectorPath.Count)
		{
			reachedEndOfPath = true;
			return;
		} else {
			reachedEndOfPath = false;
		}

		Vector2 dir = ((Vector2)path.vectorPath[currentPoint] - rb.position).normalized;
		Vector2 force = dir * speed * Time.deltaTime;

		rb.AddForce(force);

		float dist = Vector2.Distance(rb.position, path.vectorPath[currentPoint]);

		if(dist < distanceToNextPoint)
		{
			currentPoint++;
		}
	}
}