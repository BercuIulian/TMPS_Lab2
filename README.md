# Creational Design Patterns


## Author: Bercu Iulian

----

## Objectives:

* Study and understand the Creational Design Patterns.

* Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.

* Use some creational design patterns for object instantiation in a sample project.


## Used Design Patterns: 

* Singleton Pattern
* Factory Method Pattern
* Abstract Factory Pattern
* Builder Pattern


## Implementation

The Singleton pattern ensures there's only one instance of the ECommerceSystem class, providing a central point for managing products and system resources.

The Factory Method pattern allows the creation of various product types (e.g., laptops and smartphones) through separate factories, abstracting the product creation process.

The Abstract Factory pattern abstracts the creation of UI components (e.g., buttons) for different platforms (Windows and macOS) without modifying the client code.

The Builder pattern, although simplified, is represented by the ShoppingCart class, acting as a container for products, demonstrating the construction of a complex object.


* Snippets from my files.


```
// Singleton Pattern
    public class ECommerceSystem
    {
        private static ECommerceSystem instance;
        private List<Product> products = new List<Product>();

        private ECommerceSystem()
        {
            // Initialize any necessary resources or configurations here
        }

        public static ECommerceSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new ECommerceSystem();
            }
            return instance;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                product.DisplayInfo();
            }
        }
    }
```


## Conclusions / Screenshots / Results

In conclusion, design patterns are invaluable tools in software development. They offer proven solutions to recurring problems, fostering code organization, maintainability, and adaptability. By abstracting complex processes and promoting modular design, design patterns enhance code quality, facilitate collaboration among developers, and ultimately lead to more robust and flexible software solutions. Embracing design patterns empowers developers to create cleaner, more efficient, and more maintainable code, making them a cornerstone of effective software engineering practices.


* The result of running the program

  ![image](https://github.com/BercuIulian/TMPS_Lab2/assets/113422203/04440042-d7d2-4b10-8675-16e79d390f81)

