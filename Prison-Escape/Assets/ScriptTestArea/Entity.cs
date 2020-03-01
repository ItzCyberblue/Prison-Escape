using System;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {
    private string name;
    public string Name{
        get; set;
    }
    private int health;
    public int Health{
        get; set;
    }
    private int stamina;
    public int Stamina{
        get; set;
    }
    private int maxHealth;
    public int MaxHealth{
        get; set;
    }
    private int maxStamina;
    public int MaxStamina{
        get; set;
    }
    public Entity(){}
    public Entity(int health, int stamina){
        maxHealth = health;
        maxStamina = stamina;
    }
    public void Die(){
        
    }
}