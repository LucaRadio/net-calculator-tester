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
            Calculator calc = new Calculator(a,b);

            Console.WriteLine($"Input number: {a}\t{b}\n");
            Console.WriteLine($"Add: {calc.Add()}\n");
            Console.WriteLine($"Substract: {calc.Substract()}\n");
            Console.WriteLine($"Multiply: {calc.Multiply()}\n");
            Console.WriteLine($"Divide: {calc.Divide()}\n");
            Console.WriteLine($"Power: {calc.Power()}\n");

        }
    }
}