using System;

public class EvenOddProgram
{
    public static void Main()
    {
        int num;
        Console.Write("Enter a Number : ");
        num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is an Even Number");
        }
        
    }
}
