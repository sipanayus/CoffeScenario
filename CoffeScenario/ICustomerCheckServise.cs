﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeScenario
{
   internal interface ICustomerCheckServise
    {
        bool CheckIfRealPerson(Customer customer);
    }
}