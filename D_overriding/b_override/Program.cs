namespace b_override;

public class Father
{
    // The 'virtual' keyword allows this method to be overridden by child classes
    public virtual void Work()
    {
        Console.WriteLine("Father works as a Civil Engineer.");
    }

    // Another virtual method returning a value
    public virtual int GetPocketMoney()
    {
        return 1000;
    }
}

public class Son : Father
{
    // The 'override' keyword changes the parent's method implementation
    public override void Work()
    {
        Console.WriteLine("Son works as a Software Developer.");
    }

    // Overriding the method to return a different amount
    public override int GetPocketMoney()
    {
        // base.GetPocketMoney() fetches the Father's implementation before adding to it
        int baseAmount = base.GetPocketMoney(); 
        return baseAmount + 500; 
    }
}

class Program
{
    static void Main()
    {
        Father dad = new Father();
        dad.Work();
        Console.WriteLine($"Father's pocket money budget: ${dad.GetPocketMoney()}\n");

        Son child = new Son();
        child.Work(); // Calls the overridden child method
        Console.WriteLine($"Son's pocket money budget: ${child.GetPocketMoney()}");
    }
}
