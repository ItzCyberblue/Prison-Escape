using System;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {
    private int health;
    public int Health{
        get; set;
    }
    private int stamina;
    public int Stamina{
        get; set;
    }
    public Entity(){

    }
    public abstract void Die(){
        
    }
}