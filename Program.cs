using System;
using System.Collections.Generic;

namespace Lab2
{

    

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

    // Factory Method Pattern
    public abstract class Product
    {
        public abstract void DisplayInfo();
    }

    public class Laptop : Product
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Laptop: High-performance laptop with the latest CPU.");
        }
    }

    public class Smartphone : Product
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Smartphone: Sleek and powerful smartphone with a high-resolution display.");
        }
    }

    public abstract class ProductFactory
    {
        public abstract Product CreateProduct();
    }

    public class LaptopFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new Laptop();
        }
    }

    public class SmartphoneFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new Smartphone();
        }
    }

    // Abstract Factory Pattern
    public interface IUserInterfaceFactory
    {
        IButton CreateButton();
    }

    public interface IButton
    {
        void Render();
    }

    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows Button");
        }
    }

    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("MacOS Button");
        }
    }

    public class WindowsUIFactory : IUserInterfaceFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
    }

    public class MacOSUIFactory : IUserInterfaceFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }
    }

    // Builder Pattern
    public class ShoppingCart
    {
        public List<Product> Products { get; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void ShowCart()
        {
            Console.WriteLine("Shopping Cart Contents:");
            foreach (var product in Products)
            {
                product.DisplayInfo();
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Singleton Pattern
            var eCommSystem = ECommerceSystem.GetInstance();

            // Factory Method Pattern
            var laptopFactory = new LaptopFactory();
            var smartphoneFactory = new SmartphoneFactory();

            var laptop = laptopFactory.CreateProduct();
            var smartphone = smartphoneFactory.CreateProduct();

            // Abstract Factory Pattern
            IUserInterfaceFactory uiFactory;

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                uiFactory = new WindowsUIFactory();
            }
            else
            {
                uiFactory = new MacOSUIFactory();
            }

            var button = uiFactory.CreateButton();

            // Builder Pattern
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddProduct(laptop);
            shoppingCart.AddProduct(smartphone);

            // Display products and UI elements
            eCommSystem.AddProduct(laptop);
            eCommSystem.AddProduct(smartphone);
            eCommSystem.DisplayProducts();

            button.Render();

            shoppingCart.ShowCart();
        }
    }
}
