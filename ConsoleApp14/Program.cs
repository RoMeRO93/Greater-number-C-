internal class Program
{
    private static void Main(string[] args)
    {
        int x = 20;
        int y = 18;
        string operation = ">";
        string resultMessage = "{0} {1} {2}";

        if (x == y)
        {
            operation = "==";
            resultMessage = "{0} {1} {2}";
        }
        else if (x < y)
        {
            operation = "<";
            resultMessage = "{0} {1} {2}";
        }

        Console.WriteLine(resultMessage, x, operation, y);

        int[] numbers = new int[] { 10, 15, 20, 25, 30 };

        Console.WriteLine("The numbers greater than x are:");

        foreach (int number in numbers)
        {
            if (number > x)
            {
                Console.WriteLine(number);
            }
        }

        Console.WriteLine("Enter a number:");

        int z = int.Parse(Console.ReadLine());

        switch (z)
        {
            case 1:
                Console.WriteLine("You entered one");
                break;
            case 2:
                Console.WriteLine("You entered two");
                break;
            case 3:
                Console.WriteLine("You entered three");
                break;
            default:
                Console.WriteLine("You entered an invalid number");
                break;
        }
    }
}