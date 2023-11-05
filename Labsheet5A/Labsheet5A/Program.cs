namespace TestCashRegister;

class Program
{
    static void Main(string[] args)
    {
        CashRegister CR1 = new CashRegister();

        Console.WriteLine("adding an item worth 2.70 to CR1");
        CR1.AddItem(2.70);
        Console.WriteLine("adding an item worth 3.45 to CR1");
        CR1.AddItem(3.45);
        Console.WriteLine("adding an item worth 5.97 to CR1");
        CR1.AddItem(5.97);


        Console.WriteLine("Cash Register 1 total = {0}", CR1.Total);
        Console.WriteLine("Cash Register 1 Number of items = {0}", CR1.NumberOfItems);



        Console.ReadLine();
    }
}

