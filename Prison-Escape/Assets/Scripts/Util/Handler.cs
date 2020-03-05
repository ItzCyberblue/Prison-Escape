using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PrisonEscape.Utility
{
	public class Handler : MonoBehaviour 
	{

		private int player_id;
		public string[] fates;
		private int chosen_fate;

		public static bool player_dead = false;

		void Start()
		{

			player_id = Random.Range(100, 1000);
			chosen_fate = Random.Range(0, fates.Length);
			Debug.Log("Player " + player_id + " has joined the game!");
			Debug.Log("You are " + fates[chosen_fate]);

		}

		public static void KillPlayer()
		{

			player_dead = true;
			Debug.Log("Player is dead");
			SceneManager.LoadScene(1);

		}

	}
}