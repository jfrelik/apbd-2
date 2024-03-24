using ex2.Cargos;
using ex2.utils;

namespace ex2.Containers;

public class CoolerContainer : ShipContainer
{
    private double _temperature;
    private CargoType? _cargoType;
    private List<Cargo> _cargoes;

    public CoolerContainer(double height, double ownMass, double depth, double cargoMaxMass, double temperature) : base(
        height, ownMass,
        depth, cargoMaxMass, ContainerType.Cooler)
    {
        this._temperature = temperature;
        _cargoes = new List<Cargo>();
    }

    public override void SetCargo(Cargo cargo)
    {
        if (_cargoType == null)
        {
            _cargoType = cargo.GetCargoType();
            if (cargo.GetCargoTemperature() > _temperature)
            {
                throw new Exception("Cargo temperature is too high for this container!");
            }

            base.SetCargo(cargo);
            _cargoes.Add(cargo);
        }
        else
        {
            if (cargo.GetCargoType() != _cargoType)
            {
                throw new Exception("Cargo type does not match container type!");
            }


            if (cargo.GetCargoTemperature() > _temperature)
            {
                throw new Exception("Cargo temperature is too high for this container!");
            }

            base.SetCargo(cargo);
            _cargoes.Add(cargo);
        }
    }

    public override void RemoveCargo()
    {
        if (_cargoes.Count > 0)
        {
            _cargoes.RemoveAt(_cargoes.Count - 1);
            if (_cargoes.Count > 0)
            {
                _cargo = _cargoes[_cargoes.Count - 1];
            }
            else
            {
                _cargo = null;
            }
        }
    }
}