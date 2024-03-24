using ex2.Cargos;
using ex2.Interfaces;
using ex2.utils;

namespace ex2.Containers;

public class LiquidContainer: ShipContainer, IHazardNotifier
{
    public LiquidContainer(double height, double ownMass, double depth, double cargoMaxMass) : base(height, ownMass, depth, cargoMaxMass, ContainerType.Liquid)
    {}

    public override void SetCargo(Cargo cargo)
    {
        if (cargo.GetCargoType() == CargoType.Hazardous && cargo.GetMass() > (_cargoMaxMass * 0.5))
        {
            ((IHazardNotifier)this).NotifyOfHazard("Hazardous cargo in liquid container with mass over 50% of max capacity! Aborting...");
            return;
        }
        
        if (cargo.GetCargoType() == CargoType.Safe && cargo.GetMass() > (_cargoMaxMass * 0.9))
        {
            ((IHazardNotifier)this).NotifyOfHazard("Safe cargo in liquid container with mass over 90% of max capacity! Aborting...");
            return;
        }
        
        base.SetCargo(cargo);
    }
}