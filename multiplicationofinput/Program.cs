namespace classandobject
{
    class multiplyThree
    {
        int firstnum;
        int secondnum;

        int thirdnum;

        public void input(int a, int b, int c)
        {
            firstnum = a;
            secondnum = b;
            thirdnum=c;
        }

        public void multiply()
        {
            int multiply = firstnum * secondnum *thirdnum;
            Console.WriteLine("sum is  = " + multiply);
        }

        static void Main(string[] args)
        {
            multiplyThree r1 = new multiplyThree();
            r1.input(10, 10, 10);
            r1.multiply();
        }
    }
}