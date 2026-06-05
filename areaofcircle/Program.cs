namespace classandobject
{
    class Rectangle
    {
        int radius;       
        public void input(int r)
        {
            radius = r;
            
        }
        public void area()
        {
            int area = radius*radius;
            Console.WriteLine("Area of circle = " + area);
        }

        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.input(7);
            r1.area();
        }
    }
}