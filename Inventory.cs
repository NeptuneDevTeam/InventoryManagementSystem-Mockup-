using System;
using System.Collections.Generic;

namespace Project
{

    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }
//CRRUD
        //Create
        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine();
        }

        //Delete
        public void removeItem(long id)
        {
            var itemToRemove = items.Find(item => item.ID == id);
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                Console.WriteLine();

            }
            else
            {
                System.Console.WriteLine("Item NOT FOUND");
            }
        }
        //Read
        public void DisplayInventory()
        {
            System.Console.WriteLine("\nInventory:");
            foreach (var item in items)
            {
                item.Display();
            }
        }

        //READ BY ID
        public void SearchItemByID(long id)
        {
            var item = items.Find(i => i.ID == id);
            if(item != null)
            {
                item.Display();
            }
            else
            {
                System.Console.WriteLine("Item not Found.");
            }
        }
        //Update
        public void UpdateItemQuantity(long id, long newQuantity)
        {
            var item = items.Find(i => i.ID == id);
            if(item != null)
            {
                item.Quantity = newQuantity;
                System.Console.WriteLine();
            }
             else
            {
                System.Console.WriteLine("Item not Found.");
            }
        }
        
    }
}