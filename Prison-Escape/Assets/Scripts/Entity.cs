using System;
using System.Collections.Generic;
using UnityEngine;

namespace PrisonEscape.Character
{
    public class Entity : MonoBehaviour
    {
        private GameObject gObject;

        public GameObject GObject { 
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
            MaxHealth = health;
            MaxStamina = stamina;
        }

        public Entity(int health, int stamina, GameObject g)
        {
            MaxHealth = health;
            MaxStamina = stamina;
            GObject = g;
        
        }

        public void Die(){

        }
    }
}