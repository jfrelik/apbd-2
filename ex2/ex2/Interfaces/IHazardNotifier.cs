namespace ex2.Interfaces;

public interface IHazardNotifier
{
    void NotifyOfHazard(string msg)
    {
        Console.WriteLine("[HAZARD] " + msg);
    }
}