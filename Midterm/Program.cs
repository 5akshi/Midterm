using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem (string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
         Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold <= QuantityInStock) 
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Insufficient quantity in stock.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock
    {
        get
        {
            return QuantityInStock > 0;
        }
    }

    // Print item details
    
    public void PrintDetails()
    {
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Logic to interact with the objects
        // Example tasks:

        Console.WriteLine("Welcome to the InventoryItem:");
        Console.WriteLine();

        Console.WriteLine("Below are the details of stocking to the InventoryItem:");
        Console.WriteLine();

        // 1. Print details of all items.
        Console.WriteLine("Details of Item 1:");
        item1.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Details of Item 2:");
        item2.PrintDetails();
        Console.WriteLine();

        // 2. Sell some items and then print the updated details.
        item1.SellItem(3);
        Console.WriteLine("After selling 3 items of Item 1:");
        item1.PrintDetails();
        Console.WriteLine();

        // 3. Restock an item and print the updated details.
        item2.RestockItem(5);
        Console.WriteLine("After restocking 5 items of Item 2:");
        item2.PrintDetails();
        Console.WriteLine();

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine($"Is Item 1 in stock? {item1.IsInStock}");
        Console.WriteLine($"Is Item 2 in stock? {item2.IsInStock}");
    }
}

