using System;
using System.Collections.Generic;
using UnityEngine;
using PrisonEscape.Character;

namespace PrisonEscape.Entites
{
    public class Prisoner : Entity {
        public enum State{
            Aggressive,
            Passive
        }
        public Prisoner() : base(){}
        public void Die(){

        }
    }
}