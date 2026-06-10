namespace classandobject
{
    class sumT
    {
        int firstnum;
        int secondnum;

        public void input(int a, int b)
        {
            firstnum = a;
            secondnum = b;
        }

        public void sum()
        {
            int adding = firstnum + secondnum ;
            Console.WriteLine("sum is  = " + adding);
        }

        static void Main(string[] args)
        {
            sumT r1 = new sumT();
            r1.input(10, 5);
            r1.sum();
        }
    }
}