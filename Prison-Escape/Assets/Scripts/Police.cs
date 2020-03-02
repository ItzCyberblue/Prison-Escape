using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Character;

namespace Character
{
    public class Police : Entity {
        public float RunSpeed { get; set; }
        public float WalkSpeed { get; set; }

        public enum State{
            Aggressive,
            Still,
            Patrolling
        }
        public int CurrentState = State.Still;
        public Police() : base(){

        }
        public GameObject PatrolOfficer;
        void Start()
        {
            PatrolOfficer = GameObject.Find("PatrolOfficer");
            Walking = false;
        }


        public Police(int health , int stamina) : base(health, stamina){}
        public Police(int health, int stamina, GameObject g) : base(health, stamina, g){}

        public override void Die(){
        
            Destroy(PatrolOfficer);
            Destroy(GameObject.Find("g"));
            Destroy(GObject);
        
        }
    }

}
