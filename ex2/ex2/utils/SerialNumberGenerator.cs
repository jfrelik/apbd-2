namespace ex2.utils;

public class SerialNumberGenerator
{
    private static int _containerNumber;

    static public string GenerateSerialCode(ContainerType type)
    {
        return "KON-" + type.ToString().Split().GetValue(0) + "-" + ++_containerNumber;
    }
}