using System;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public  abstract class  Entity : MonoBehaviour {
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
    public abstract void Die();
}
=======
namespace Character
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
        public Entity){}
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

        public abstract void Die();
    }
>>>>>>> d4a36ec7a4a1438eec8c07a4d924f126c989b10c
