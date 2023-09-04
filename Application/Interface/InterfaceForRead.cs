using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public  interface InterfaceForRead
    {
        public Customer ReadCustomerForCreate(Customer obj);
        public Employee ReadCustomerForEmployee(Employee obj);
    }
}
