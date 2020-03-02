using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Character;
public class Police : Entity {
    public enum State{
        Aggressive,
        Passive,
        Patrolling
    }
    public Police() : base(){

    }
    public GameObject PatrolOfficer;
     void Start()
    {
        PatrolOfficer = GameObject.Find("PatrolOfficer");
    }


    public Police(int health , int stamina) : base(health, stamina){}
    public Police(int health, int stamina, GameObject g) : base(health, stamina, g){}

    public override void Die(){
        
        Destroy(PatrolOfficer);
        Destroy(GameObject.Find("g"));
        
    }
}
