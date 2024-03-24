using ex2.Exceptions;
using ex2.utils;
using ex2.Cargos;

namespace ex2.Containers;

public class ShipContainer
{
    private double _height;
    private double _ownMass;
    private double _depth;
    private string _serialNumber;
    protected double _cargoMaxMass;
    protected Cargo? _cargo ;
    private ContainerType _type;
    public static int ContainerNumber = 0;

    public ShipContainer(double height, double ownMass, double depth, double cargoMaxMass,
        ContainerType type)
    {
        _height = height;
        _ownMass = ownMass;
        _depth = depth;
        _serialNumber = SerialNumberGenerator.GenerateSerialCode(type);
        _cargoMaxMass = cargoMaxMass;
        _type = type;
    }
    
    public virtual void SetCargo(Cargo cargo)
    {
        if (cargo.GetMass() > _cargoMaxMass)
        {
            throw new OverfillException("Cargo too heavy for container");
        }
        _cargo = cargo;
    }
    
    public Cargo GetCargo()
    {
        return _cargo ?? throw new NoCargoException("No cargo in container");
    }

    public double GetCargoMass()
    {
        return _cargo?.GetMass() ?? 0;
    }

    public virtual void RemoveCargo()
    {
        _cargo = null;
    }
    
    public double GetOwnMass()
    {
        return _ownMass;
    }
    
    public double GetCargoMaxMass()
    {
        return _cargoMaxMass;
    }
    
    override public string ToString()
    {
        return "Container " + _serialNumber + " of type " + _type + " with cargo " + (_cargo != null ? _cargo.ToString() : "No cargo");
    }
}