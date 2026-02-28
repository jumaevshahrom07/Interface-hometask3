namespace ClassDemo;

public class Lock : IDevice
{
    public bool IsLocked {get; set;}

    public void TurnOn()
    {
        IsLocked = true;
        System.Console.WriteLine("Door locked");
    }

    public void TurnOff()
    {
        IsLocked = false;
        System.Console.WriteLine("Door unlocked");
    }

    public void LockDoor()
    {
        IsLocked = true;
    }
    public void UnLockDoor()
    {
        IsLocked = false;
    }
}