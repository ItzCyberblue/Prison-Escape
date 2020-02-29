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
    enum Stats{ Health, Stamina, Strength }
    private int statEffected;
    public int StatEffected{ 
        get; set;
    }
    public Item() {
        name = String.Empty;
        description = String.Empty;
        statEffected = (int) Stats.Health;
    }
    public Item(string name, string description, int statEffected) {
        this.name = name;
        this.description = description;
        this.statEffected = statEffected;
    }
}