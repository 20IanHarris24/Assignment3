using Assignment3;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person("Terry", "Sunport", 37, 1.75, 87.6);
        Person person2 = new Person("Julia", "Turnpike", 31, 1.78, 80.3);

        person.GetFName();
        person.GetWeight();
        person2.GetFName();
        person2.GetAge();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\n\t First Name: {person.GetFName()} weight: {person.GetWeight()}KGs\n");
        Console.WriteLine($"\n\t First Name: {person2.GetFName()} age: {person2.GetAge()}years\n");



        Console.ResetColor();

        person.SetWeight(89.5);
        person2.SetAge(32);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"\n\t First Name: {person.GetFName()} updated weight: {person.GetWeight()}KGs\n");
        Console.WriteLine($"\n\t First Name: {person2.GetFName()} updated age: {person2.GetAge()}years\n");
    }
}