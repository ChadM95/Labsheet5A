using System;
namespace TestCashRegister
{
	public class CashRegister
	{
		//Properties
		public double Total { get; set; }
		public int Items { get; set; }



		//Constructor
		public CashRegister()
		{
		}

        //Methods
        public override string ToString()
        {
            return $"";
        }

		public void AddItem(double price)
		{
			Total = Total + price;
			Items++;
			Console.WriteLine($"Adding an item worth{price} to ");
		}
    }
}

