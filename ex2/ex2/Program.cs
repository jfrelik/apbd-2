// See https://aka.ms/new-console-template for more information

using ex2;
using ex2.utils;

Console.WriteLine("Hello, World!");

ShipContainer cont = new ShipContainer(100, 20, 20, 20,ContainerType.Cooler);
Cargo cargo = new Cargo(100, "Bananas");

Console.WriteLine(cont.ToString());