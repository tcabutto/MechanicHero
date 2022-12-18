using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items;
    private decimal money = 0.00m;
    [SerializeField] int maxSize;

    
    public Inventory(int size)
    {
        items = new List<Item>();
        money = 0.0m;
        maxSize = size;
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    public List<Item> GetItems()
    {
        return items;
    }
     public void AddMoney(decimal amount)
     {
      money += amount;
     }

      public void RemoveMoney(decimal amount)
     {
       money -= amount;
     }
      public decimal GetMoney()
     {
       return money;
    }
}

// The PlayerInventory class represents the player's inventory in the game.
public class PlayerInventory : Inventory
{
    // Constructor for the PlayerInventory class.
    public PlayerInventory(int size) : base(size) {}
}

// The GarageInventory class represents the different garages inventory in the game.
public class GarageInventory : Inventory
{
    public GarageInventory(int size) : base(size) {}
}
