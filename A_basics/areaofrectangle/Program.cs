namespace classandobject
{
    class Rectangle
    {
        int length;
        int breadth;

        public void input(int l, int b)
        {
            length = l;
            breadth = b;
        }

        public void area()
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle = " + area);
        }

        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.input(10, 5);
            r1.area();
        }
    }
}