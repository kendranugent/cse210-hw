using System;

class Program
{
    public static void Main(string[] args)
    {
        Address addressOne = new Address("123 State St", "Capital Hill", "VA", "USA"); //Street, Town, State, Country
        Address addressTwo = new Address("430 SpiderMonkey Avenue", "Forks", "WA", "USA");
        Address addressThree = new Address("3428 Maple Boulevard", "Vancouver", "BC", "Canada");

        Customer customerOne = new Customer("John Adams", addressOne);
        Customer customerTwo = new Customer("Bella Cullen", addressTwo);
        Customer customerThree = new Customer("Flapjack Sam", addressThree);

        Product productOne = new Product("Party Invitation Cards", "C1776", 0.43f, 200); //Name of product, Product ID, Price per unit, Quantity
        Product productTwo = new Product("RWB Pen Pack", "P0704", 1.50f, 5);
        Product productThree = new Product("Capital Hill Sticky notes", "S106", 2.50f, 3);
        Product productFour = new Product("Blue sticky tab pack", "S713", 1.59f, 7);
        Product productFive = new Product("Mythical Creature Highlighter Pack", "P4521", 3.99f, 4);
        Product productSix = new Product("Pancake Sticky notes", "S621", 2.45f, 2);
        Product productSeven = new Product("Label maker", "M3486", 12.16f, 1);

        Order orderOne = new Order(customerOne);
        orderOne.AddProduct(productOne);
        orderOne.AddProduct(productTwo);
        orderOne.AddProduct(productThree);

        Order orderTwo = new Order(customerTwo);
        orderTwo.AddProduct(productFour);
        orderTwo.AddProduct(productFive);

        Order orderThree = new Order(customerThree);
        orderThree.AddProduct(productSix);
        orderThree.AddProduct(productSeven);

        Console.WriteLine(orderOne.PackingLabel());
        Console.WriteLine(orderOne.ShippingLabel());
        Console.WriteLine($"Total Cost: ${orderOne.TotalCost()}");
        Console.WriteLine();

        Console.WriteLine(orderTwo.PackingLabel());
        Console.WriteLine(orderTwo.ShippingLabel());
        Console.WriteLine($"Total Cost: ${orderTwo.TotalCost()}");
        Console.WriteLine();

        Console.WriteLine(orderThree.PackingLabel());
        Console.WriteLine(orderThree.ShippingLabel());
        Console.WriteLine($"Total Cost: ${orderThree.TotalCost()}");
        Console.WriteLine();
    }
}