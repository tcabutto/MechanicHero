using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int id;
    public string title;
    public string description;
    string biome;
    public Sprite icon;
    //public Dictionary<string, int> stats = new Dictionary<string, int>();  //will revisit if this is needed. Not sure yet

  public Item(int id, string title, string description, string biome)
  {
    this.id = id;
    this.title = title;
    this.description = description;
    this.biome = biome;
    this.icon = Resources.Load<Sprite>("Sprites/Items/" + title);
    
  }

  public Item(Item item)
  {
    this.id = item.id;
    this.title = item.title;
    this.description = item.description;
    this.icon = Resources.Load<Sprite>("Sprites/Items/" + item.title);
    this.biome = item.biome;
  }
    
}
