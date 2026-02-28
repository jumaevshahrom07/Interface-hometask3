namespace ClassDemo;

public class Thermostat : IDevice
{
    public bool IsOn{get; set;}

    public double Temperature {get; set;}

    public void TurnOn()
    {
        IsOn = true;
        System.Console.WriteLine("Thermostat is on");
    }

    public void TurnOff()
    {
        IsOn = false;
        System.Console.WriteLine("Thermostat is off");
    }

    public void SetTemperature(double temperature)
    {
        Temperature = temperature;
        Console.WriteLine("Temperatue set to " + Temperature);
    }
}