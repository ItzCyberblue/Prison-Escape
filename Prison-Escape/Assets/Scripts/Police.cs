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
    public Police(int health , int stamina) : base(health, stamina){}
    public override void Die(){
        
        Destroy(gameObject.PatrolOfficer);
        
    }
}