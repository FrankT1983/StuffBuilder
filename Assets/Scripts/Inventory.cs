using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private SpriteRenderer Renderer;

    void Start()
    {
        this.Renderer = GetComponent<SpriteRenderer>();
    }


    //public List<Item> items = new List<Item>();

    public Item[] items = new Item[numItemSlots];
    public const int numItemSlots = 4;
    public void AddItem(Item itemToAdd)
    {
        for (int i = 0; i< items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;              
                return;
            }
        }
    }

    internal void ToggleVisibility()
    {
        if (this.Renderer != null)
        {
            this.Renderer.enabled = !this.Renderer.enabled;
        }
    }

    public void RemoveItem(Item itemToRemove)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
                return;
            }
        }
    }
}
