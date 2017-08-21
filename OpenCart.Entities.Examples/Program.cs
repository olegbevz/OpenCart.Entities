using System;
using System.Linq;
using JustWatch.OpenCart;

namespace OpenCart.Entities.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (IOpenCartDomain openCartDomain = new OpenCartDomain())
                {
                    var products = openCartDomain.Products.Include("Manufacturer")
                        .Where(product => product.Manufacturer.Name == "Casio")
                        .ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
