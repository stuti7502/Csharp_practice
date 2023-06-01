using System;
namespace EncapsulationDemo
{
    public class Bank
    {
        private double _Amount;
        public double Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                // Validate the value 
                if (value < 0)
                {
                    throw new Exception("Please Pass a Positive Value");
                }
                else
                {
                    _Amount = value;
                }
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            try
            {
                Bank bank = new Bank();
                bank.Amount = 10;
                Console.WriteLine(bank.Amount);

                
                bank.Amount = -150;
                Console.WriteLine(bank.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}