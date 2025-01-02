using System;

namespace Project
{
    public class Item
    {
        public string Name { get; set; }
        public long ID { get; set; }
        public long Quantity { get; set; }
        public long Price { get; set; }

        public Item(string name, long id, long quantity, long price)
        {
            Name = name;
            ID = id;
            Quantity = quantity;
            Price = price;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Quantity: {Quantity}, Price: ${Price:F2}");
        }
    }

}
 