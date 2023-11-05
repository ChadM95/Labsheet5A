namespace TestCashRegister;

class Program
{
    static void Main(string[] args)
    {
        CashRegister CR1 = new CashRegister();
        CashRegister CR2 = new CashRegister();


        Console.WriteLine("adding an item worth 2.70 to CR1");
        CR1.AddItem(2.70);
        Console.WriteLine("adding an item worth 3.45 to CR1");
        CR1.AddItem(3.45);
        Console.WriteLine("adding an item worth 5.97 to CR1");
        CR1.AddItem(5.97);

        Console.WriteLine("adding an item worth 12.52 to CR2");
        CR2.AddItem(12.52);
        Console.WriteLine("adding an item worth 1.43 to CR2");
        CR2.AddItem(1.43);
        Console.WriteLine("adding an item worth 15.57 to CR2");
        CR2.AddItem(15.57);
        Console.WriteLine("adding an item worth 5.15 to CR2");
        CR2.AddItem(5.15);


        Console.WriteLine("Cash Register 1 total = {0}", CR1.Total);
        Console.WriteLine("Cash Register 1 Number of items = {0}", CR1.NumberOfItems);

        Console.WriteLine("Cash Register 2 total = {0}", CR2.Total);
        Console.WriteLine("Cash Register 2 Number of items = {0}", CR2.NumberOfItems);

        Console.ReadLine();
    }
}

