using ex2.utils;

namespace ex2;

public class ShipContainer
{
    private double _height;
    private double _ownMass;
    private double _depth;
    private string _serialNumber;
    private double _maxMass;
    private Cargo _cargo;

    public ShipContainer(double height, double ownMass, double depth, double maxMass,
        ContainerType type)
    {
        _height = height;
        _ownMass = ownMass;
        _depth = depth;
        _serialNumber = SerialNumberGenerator.GenerateSerialCode(type);
        _maxMass = maxMass;
    }
    
    public void SetCargo(Cargo cargo)
    {
        _cargo = cargo;
    }
    
    public Cargo GetCargo()
    {
        return _cargo;
    }
    
    public void RemoveCargo()
    {
        _cargo = null;
    }
    
    override public string ToString()
    {
        return "Container " + _serialNumber;
    }
}