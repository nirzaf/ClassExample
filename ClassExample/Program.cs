using static System.Console;
public class Sample
{
    static void Main()
    {
        //objects
        var c1 = new Customer();
        var c2 = new Customer();

        c1.custmerID = 123;
        c1.customerName = "Farook";
        c2.custmerID = 21112;
        c2.customerName = "Fazrin";

        WriteLine("Customer Id : {0}, Customer Name:{1}", c1.custmerID, c1.customerName);
        WriteLine("Customer Id : {0}, Customer Name:{1}", c2.custmerID, c2.customerName);
        ReadKey();

    }
}

