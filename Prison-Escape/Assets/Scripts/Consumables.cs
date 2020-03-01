using System;
using System.Collections.Generic;
using UnityEngine;

public class Consumables : Item
{
    int statEffected = health;
    int valueEffected = 0; 
    public Consumables(string name, string description, int valueEffected, int statEffected) : base(name, description)
    {
        this.valueEffected = valueEffected;
        this.statEffected = statEffected;        
    }
    public Consumables() : base()
    {
        
    }
    
}