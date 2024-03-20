namespace ex2;

public class Cargo
{
   private double _mass;
   private string _name;
   
   public Cargo(double mass, string name)
   {
       _mass = mass;
       _name = name;
   }
   
   public double GetMass()
   {
       return _mass;
   }
   
   public string GetName()
   {
       return _name;
   }
}