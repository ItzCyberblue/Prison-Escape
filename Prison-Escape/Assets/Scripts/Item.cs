using System;
using System.Collections.Generic;

public class Item
{
    private int value;
    public int Value{
        get; set;
    }
    private string name;
    public string Name{
        get; set;
    }
    private string description;
    public string Description{
        get; set;
    }
    public enum Stats{ Health, Stamina, Strength }
    private int statEffected;
    public int StatEffected{ 
        get; set;
    }
    public Item() {
        name = String.Empty;
        description = String.Empty;
        statEffected = -1;
    }
    public Item(string name, string description) {
        this.name = name;
        this.description = description;
        statEffected = -1;
    }
    
}