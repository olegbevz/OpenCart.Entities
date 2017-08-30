using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace OpenCart.Entities.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var openCartDomain = new OpenCartDomain())
                {
                    var entities = openCartDomain.GetType().Assembly.GetTypes()
                        .Where(type => !type.IsInterface &&
                            !type.IsSealed &&
                            !type.IsAbstract &&
                            type.GetCustomAttributes(typeof(TableAttribute), false).Length > 0);

                   

                    var products = openCartDomain.Products.Include("Manufacturer")
                        .Where(product => product.Manufacturer.Name == "Casio")
                        .ToArray();

                    var orders = openCartDomain.Orders.ToArray();

                    foreach (var entity in entities)
                    {
                        var set = openCartDomain.Set(typeof(Blog)).AsNoTracking().;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
