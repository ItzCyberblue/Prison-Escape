using System;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    public abstract class Entity : MonoBehaviour {
        public GameObject GObject{
            get; set;
        }
        public string Name{
            get; set;
        }
        public int Health{
            get; set;
        }
        public int Stamina{
            get; set;
        }
        public int MaxHealth{
            get; set;
        }
        public int MaxStamina{
            get; set;
        }
        public Entity(){}
        public Entity(int health, int stamina){
            maxHealth = health;
            maxStamina = stamina;
        }
        public abstract void Die();
    }
}
