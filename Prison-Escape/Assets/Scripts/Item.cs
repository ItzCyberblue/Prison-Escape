using System;
using System.Collections.Generic;

public class Item
{
    public int Value{
        get; set;
    }
    public string Name{
        get; set;
    }
    public string Description{
        get; set;
    }
    public enum Stats{ Health, Stamina, Strength }
    public int StatEffected{ 
        get; set;
    }
    public Item() {
        string name = String.Empty;
        string description = String.Empty;
        int statEffected = -1;
    }
    public Item(string name, string description) {
        this.Name = name;
        this.Description = description;
        int statEffected = -1;
    }
    
}