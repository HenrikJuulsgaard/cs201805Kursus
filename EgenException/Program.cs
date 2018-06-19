using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StockItem s = new StockItem(-1);
            }
            catch (StockItemException ex)
            {
                Console.WriteLine("stock Item error");
            }
            catch (Exception)
            {
                Console.WriteLine("general error");
            }

            Console.Read();
        }
    }
    public class StockItem
    {
        public int Id { get; set; }
        public StockItem(int Id)
        {
            if (Id<0)
            {
                throw new StockItemException("Wrong id");
            }
        }
    }
    public class StockItemException : Exception
    {
        public StockItemException(string message) : base(message) { }
    }
}
