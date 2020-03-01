using System;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {
    int attackDamage;
    int AttackDamage{
        get; set;
    }
    int attackSpeed;
    int AttackSpeed{
        get; set;
    }
    int durability;
    int Durability{
        get; set;
    }
    public Weapon(int valueEffected, int durability) : base() {
        attackDamage = valueEffected;
        this.durability = durability;
    }
    public Weapon(string name, string description, int valueEffected, int durability) : base(name, description){
        attackDamage = valueEffected;
        this.durability = durability;
    }
    // Returns true if the entity died
    public bool Attack(Entity victim){
        victim.Health -= attackDamage;
        if(victim.Health >= 0){
            victim.Die();
            return true;
        }

        return false;
    }
    
}