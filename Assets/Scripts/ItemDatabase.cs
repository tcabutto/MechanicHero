using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items;

    public void Awake()
    {
        BuildDatabase();
    }
    void BuildDatabase()
    {
        items = new List<Item>()
        {
            new Item
                (
                    0,
                    "battery1",
                    "A battery to charge your car",
                    Item.Biome.All
                )
        };
    }
}
