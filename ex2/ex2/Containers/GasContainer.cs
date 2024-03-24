using ex2.Cargos;
using ex2.Interfaces;
using ex2.utils;

namespace ex2.Containers;

public class GasContainer: ShipContainer, IHazardNotifier
{
    private double _fivePercentMass;
    
    public GasContainer(double height, double ownMass, double depth, double cargoMaxMass) : base(height, ownMass, depth, cargoMaxMass, ContainerType.Gas)
    {}

    public override void SetCargo(Cargo cargo)
    {
        _fivePercentMass = _cargoMaxMass * 0.05;

        if (cargo.GetCargoType() == CargoType.Hazardous)
        {
            ((IHazardNotifier)this).NotifyOfHazard("Hazardous cargo in gas container!");
        }
        base.SetCargo(cargo);
    }
    
    public override void RemoveCargo()
    {
        if (_cargo?.GetMass() > _fivePercentMass)
        {
            _cargo.SetCargoMass(_fivePercentMass);
        }
        
        if(_cargo?.GetMass() == _fivePercentMass)
        {
            ((IHazardNotifier)this).NotifyOfHazard("Cargo mass is 5% of its capacity, cannot remove more cargo!");
        }
    }
}
