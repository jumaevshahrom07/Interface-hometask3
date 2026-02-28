// namespace ClassDemo;

// public class Student : Person
// {
//     public void Study()
//     {
//         Console.WriteLine("I'm studying");
//     }

//     public void ShowAge()
//     {
//         Console.WriteLine("My age is: " + _age + " years old");
//     }
// }

















namespace ClassDemo;

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }

    public void ShowAge()
    {
        Console.WriteLine($"My age is: {_age} years old");
    }
}