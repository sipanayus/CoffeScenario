using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeScenario
{
    internal class CustomerCheckManager : ICustomerCheckServise
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
