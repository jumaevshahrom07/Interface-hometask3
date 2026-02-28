namespace ClassDemo;

public class Lamp : IDevice
{
    public bool IsOn {get; set;}

    public int Brightness{get; set;}


    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Lamp is on");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Lamp is off");
    }

    public void SetBrightness(int level)
    {
        Brightness = level;
        Console.WriteLine("Brightness " + Brightness);
    }
}