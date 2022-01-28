using static System.Console;
public class Sample
{
    static void Main()
    {
        //objects
        var c1 = new Customer();
        var c2 = new Customer();

        c1.CustomerId = 123;
        c1.CustomerName = "Farook";
        c2.CustomerId = 21112;
        c2.CustomerName = "Fazrin";

        WriteLine("Customer Id : {0}, Customer Name:{1}", c1.CustomerId, c1.CustomerName);
        WriteLine("Customer Id : {0}, Customer Name:{1}", c2.CustomerId, c2.CustomerName);
        ReadKey();

    }
}

