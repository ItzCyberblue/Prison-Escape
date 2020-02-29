using System;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {
    public Weapon() : base() {

    }

    public Weapon(string name, string description, int statEffected) : base(name, description, statEffected){
        
    }
}