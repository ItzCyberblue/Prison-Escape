using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    public List<Item> ItemList;
    public Item getItem(string name){
        for(int i = 0; i < ItemList.Count; i++){
            if(ItemList[i].Name == name){
                return ItemList[i];
            }
        }
    }
    public Item getItem(int index){
        return ItemList[index];
    }
    public void setItem(int index, Item i) {
        if(index >= ItemList.Count){
            ItemList.Add(i);
        } else {
            ItemList[index] = i;
        }
    }
    public int getIndex(string name){
        for(int i = 0; i < ItemList.Count; i++){
            if(ItemList[i].Name == name){
                return i;
            }
        }
    }
}