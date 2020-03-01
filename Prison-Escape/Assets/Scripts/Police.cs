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
    public Police(int health, int stamina, GameObject g) : base(health, stamina, g){}
    

    public override void Die(){
        
        Destroy(gObject);
        
    }
}