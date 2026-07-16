namespace g_intefacewithinterface;
public interface IBasicPrinter
{
    void Print(); 
}

public interface ISmartPrinter : IBasicPrinter
{
    void Scan(); 
}

public class OfficePrinter : ISmartPrinter
{
    public void Print()
    {
        System.Console.WriteLine("Printing paper...");
    }
    public void Scan()
    {
        System.Console.WriteLine("Scanning document...");
    }
}