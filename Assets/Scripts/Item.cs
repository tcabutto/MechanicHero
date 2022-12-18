using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Biome biome;
    
    [Flags] //example:  Item item = new Item("Battery", "A battery to charge your car", Item.Biome.Forest | Item.Biome.Desert);
    public enum Biome
    {
      All,
      Desert,
      Forest,
      City, 
      Mountains,
      Fallout,
      Cave
    }
    //public Dictionary<string, int> stats = new Dictionary<string, int>();  //will revisit if this is needed. Not sure yet

  public Item(int id, string title, string description, Biome biome)
  {
    this.id = id;
    this.title = title;
    this.description = description;
    this.biome = biome;
    this.icon = Resources.Load<Sprite>("Art/Sprites/Items/" + title);
    
  }

  public Item(Item item)
  {
    this.id = item.id;
    this.title = item.title;
    this.description = item.description;
    this.icon = Resources.Load<Sprite>("Art/Sprites/Items/" + item.title);
    this.biome = item.biome;
  }
    
}
