using System;
using System.Collections.Generic;
using UnityEngine;
public class Police : Entity {
    public enum State{
        Aggressive,
        Passive,
        Patrolling
    }
    public Police() : base(){

    }
    public override void Die(){
        
        Destroy(gameObject.PatrolOfficer);
        
    }
}