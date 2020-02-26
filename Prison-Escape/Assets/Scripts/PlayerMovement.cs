using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

	public float speed;

	private Rigidbody2D rb;
	private Vector2 moveVelocity;

	void Start()
	{

		rb = this.GetComponent<Rigidbody2D>();

	}

	void Update()
	{

		Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveVelocity = input * speed;

	}

	void FixedUpdate()
	{

		rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

	}

}