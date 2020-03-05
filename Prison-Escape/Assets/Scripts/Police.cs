using System;
using System.Collections.Generic;
using UnityEngine;
using PrisonEscape.Character;

namespace PrisonEscape.Entites
{ 
    public class Police : Entity {

        public GameObject gObject;
        public enum State{
            Aggressive,
            Passive,
            Patrolling
        }
        public Police() : base(){

        }
        public Police(int health , int stamina) : base(health, stamina){}
        public Police(int health, int stamina, GameObject g) : base(health, stamina, g){}
        

        public void Die(){
            Destroy(gObject);
        }
    }
}