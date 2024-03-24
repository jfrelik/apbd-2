using ex2;
using ex2.Containers;
using ex2.utils;
using ex2.Cargos;

new LiquidContainer(100, 20, 20, 200);
new LiquidContainer(100, 20, 20, 200);
new LiquidContainer(100, 20, 20, 200);
GasContainer gas = new GasContainer(100, 20, 20, 200);
LiquidContainer cont = new LiquidContainer(100, 20, 20, 200);
Cargo cargo = new Cargo(190, "FUEL", CargoType.Hazardous);
cont.SetCargo(cargo);

gas.SetCargo(cargo);
Console.WriteLine(gas.GetCargoMass());
gas.RemoveCargo();
Console.WriteLine(gas.GetCargoMass());
gas.RemoveCargo();
Console.WriteLine(gas.GetCargoMass());

Ship ship = new Ship(10, 20000, 20);
ship.AddContainer(cont);
ship.AddContainer(gas);
ship.AddContainer(new LiquidContainer(100, 20, 20, 200));

