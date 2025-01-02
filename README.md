# Inventory Management System

A simple Inventory Management System written in C#. This system allows you to manage items in a character's inventory. The code includes the following classes:

- **Item**: Represents an item that can be added to or removed from an inventory.
- **Character**: Represents a character that owns an inventory and can manage items.
- **Inventory**: Manages the collection of items for a character.

## Features

- Add items to a character's inventory.
- Remove items from a character's inventory.
- View the contents of a character's inventory.

## Classes Overview

### Item Class

The `Item` class represents an individual item in the inventory. Each item has the following properties:

- **Name**: The name of the item (e.g., "Health Potion").
- **Description**: A description of the item.
- **Quantity**: The number of the item available.

### Character Class

The `Character` class represents a character in the system. Each character has an inventory and can perform operations on it, such as adding or removing items. The `Character` class includes:

- **Inventory**: An instance of the `Inventory` class that stores the items for the character.
- **AddItem()**: Adds an item to the character's inventory.
- **RemoveItem()**: Removes an item from the character's inventory.

### Inventory Class

The `Inventory` class is responsible for managing a collection of items. It supports the following operations:

- **AddItem()**: Adds an item to the inventory.
- **RemoveItem()**: Removes an item from the inventory.
- **ViewInventory()**: Displays the contents of the inventory.

## Requirements

- .NET 6.0 or later
- Visual Studio or any compatible C# IDE

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/InventoryManagement.git
