using ex2.Containers;

namespace ex2.utils;

public class SerialNumberGenerator
{
    static public string GenerateSerialCode(ContainerType type)
    {
        return "KON-" + type.ToString()[0] + "-" + ++ShipContainer.ContainerNumber;
    }
}