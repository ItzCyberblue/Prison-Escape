using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolCatch : MonoBehaviour 
{

	void OnCollisionEnter2D(Collision2D coll)
	{

		if(coll.collider.tag == "Player")
		{

			Handler.KillPlayer();

		}

	}

}