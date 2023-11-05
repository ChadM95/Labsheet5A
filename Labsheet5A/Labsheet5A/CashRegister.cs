using System;
namespace TestCashRegister
{
	public class CashRegister
	{
		//Properties
		public double Total { get; set; }
		public int NumberOfItems { get; set; }



		//Constructor not needed
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
			Total += price;
			NumberOfItems++;
		}
    }
}

