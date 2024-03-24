namespace ex2.Cargos;

public class Cargo
{
   private double _mass;
   private string _name;
   private CargoType _type;
   private double _cargoTemperature;
   
   public Cargo(double mass, string name, CargoType type)
   {
       _mass = mass;
       _name = name;
       _type = type;
   }
   
   public Cargo(double mass, string name, CargoType type, double temperature)
   {
       _mass = mass;
       _name = name;
       _type = type;
       _cargoTemperature = temperature;
   }
   
   
   public double GetMass()
   {
       return _mass;
   }
   
   public string GetName()
   {
       return _name;
   }
   
   public void SetCargoMass(double mass)
   {
       _mass = mass;
   }
   
   public CargoType GetCargoType()
   {
       return _type;
   }
   
   public double GetCargoTemperature()
   {
       return _cargoTemperature;
   }

   public override string ToString()
   {
       return _name + " of type " + _type + " with mass " + _mass + "kg";
   }
}