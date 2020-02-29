using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

	public float speed;
	public float sprintSpeed;
	public float stamina;
	private float stamina_max = 500f;

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

		if(Input.GetKeyDown(KeyCode.LeftShift))
		{

			speed = sprintSpeed;
			stamina--;

		}

		if(Input.GetKeyUp(KeyCode.LeftShift))
		{

			speed = 10f;
			stamina++;

		}

		if(stamina <= 0)
		{

			speed = 10f;
			stamina++;

		}

		if(stamina > stamina_max)
		{

			stamina = stamina_max;

		}

	}

	void FixedUpdate()
	{

		rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

	}

}