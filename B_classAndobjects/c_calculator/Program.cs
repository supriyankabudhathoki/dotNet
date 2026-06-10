namespace c_calculator
{
    class Calculator
    {
        double a;
        double b;

        public void Input(double num1, double num2)
        {
            a = num1;
            b = num2;
        }

        public void Add()
        {
            Console.WriteLine("Addition = " + (a + b));
        }

        public void Subtract()
        {
            Console.WriteLine("Subtraction = " + (a - b));
        }

        public void Multiply()
        {
            Console.WriteLine("Multiplication = " + (a * b));
        }

        public void Divide()
        {
            if (b == 0)
                Console.WriteLine("Cannot divide by zero!");
            else
                Console.WriteLine("Division = " + (a / b));
        }

        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.Input(10, 5);
            c1.Add();
            c1.Subtract();
            c1.Multiply();
            c1.Divide();
        }
    }
}