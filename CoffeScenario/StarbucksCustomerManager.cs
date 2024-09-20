using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeScenario
{
    internal class StarbucksCustomerManager:BaseCustomerManager
    {

        ICustomerCheckServise  _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckServise customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public  void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("geçerli kişi değil");
            }
                
        }

    }
}
