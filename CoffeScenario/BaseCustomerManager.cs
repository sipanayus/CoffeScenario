using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeScenario
{
    internal abstract class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine(  "saved to db : " +customer.FirstName);
        }
    }
}
