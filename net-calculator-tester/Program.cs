namespace net_calculator_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|                 Calculator                |");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Insert first number: ");
            int a;
            int b;


            while(!int.TryParse(Console.ReadLine(),out a))
            {
                Console.WriteLine("Insert a valid number!");
            }
            Console.Write("Insert second number: ");


            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Insert a valid number!");
            }
            Calculator calc = new Calculator();

            Console.WriteLine($"Input number: {a}\t{b}\n");
            Console.WriteLine($"Add: {calc.Add(a, b)}\n");
            Console.WriteLine($"Substract: {calc.Substract(a, b)}\n");
            Console.WriteLine($"Multiply: {calc.Multiply(a, b)}\n");
            Console.WriteLine($"Divide: {calc.Divide(a, b)}\n");
            Console.WriteLine($"Power: {calc.Power(a, b)}\n");


        }
    }
}