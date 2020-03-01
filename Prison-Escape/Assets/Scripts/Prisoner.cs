using System;
using System.Collections.Generic;
using UnityEngine;
public class Prisoner : Entity {
    public enum State{
        Aggressive,
        Passive
    }
    public Prisoner() : base(){}
    public override void Die(){

    }
}