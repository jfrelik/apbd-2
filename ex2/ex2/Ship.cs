using ex2.Containers;

namespace ex2;

public class Ship
{
    private List<ShipContainer> _containers;
    private int _maxContainers;
    private double _maxMass;
    private double _speed;
    private double _currentMass;

    public Ship(int maxContainers, double maxMass, double speed)
    {
        _containers = new List<ShipContainer>();
        _maxContainers = maxContainers;
        _maxMass = maxMass;
        _speed = speed;
    }

    public void AddContainer(ShipContainer container)
    {
        if (_containers.Count < _maxContainers)
        {
            if (_currentMass + container.GetOwnMass() + container.GetCargoMaxMass() <= _maxMass)
            {
                _containers.Add(container);
                _currentMass += container.GetOwnMass() + container.GetCargoMaxMass();
            }
            else
            {
                throw new Exception("Ship is too heavy to add this container!");
            }
        }
        else
        {
            throw new Exception("Ship is full!");
        }
    }
    
    public void removeContainer(ShipContainer container)
    {
        if (_containers.Contains(container))
        {
            _containers.Remove(container);
            _currentMass -= container.GetOwnMass() + container.GetCargoMaxMass();
        }
        else
        {
            throw new Exception("Container not found on ship!");
        }
    }
    
    public void removeAllContainers()
    {
        _containers.Clear();
        _currentMass = 0;
    }
    
    public void replaceContainer(ShipContainer oldContainer, ShipContainer newContainer)
    {
        if (_containers.Contains(oldContainer))
        {
            _containers.Remove(oldContainer);
            _containers.Add(newContainer);
            _currentMass -= oldContainer.GetOwnMass() + oldContainer.GetCargoMaxMass();
            _currentMass += newContainer.GetOwnMass() + newContainer.GetCargoMaxMass();
        }
        else
        {
            throw new Exception("Container not found on ship!");
        }
    }
    
    

    public override string ToString()
    {
        return "Ship with " + _speed + "kt ,cargo: " + _containers.Count + " containers and " + _currentMass + "kg of cargo out of " + _maxMass + "kg max mass.";
    }
    
    public string GetContainerList()
    {
        string containerList = "";
        foreach (var container in _containers)
        {
            containerList += container.ToString() + "\n";
        }

        return containerList;
    }
}