// The program calculates parity of a number.

using System;
class Program
{
    // function without any return type declaration  
    public int GetNumber(string VarName)
    {
        int res;
        string input;
        do
        {
            Console.WriteLine(String.Format("Enter number: {0} = ", VarName));
            input = Console.ReadLine();
        } while (int.TryParse(input, out res) == false);
        return res;
    }

    public static void Main(string[] args)
    {
        Program pr = new Program(); // Creating a class Object  
        Console.WriteLine("The program calculates parity of a number.");

        string VarName_a = "a";
        int a = pr.GetNumber(VarName_a);
        bool is_parity = false;
        if (a % 2 == 0) {
            is_parity = true;
        }
        
        Console.WriteLine(String.Format("The value {0} is {1}", a, is_parity));
    }
}