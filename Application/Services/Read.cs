using Application.Interface;
using Domain.Models;
namespace Application.Services
{
    public class Read : InterfaceForRead
    {
        public Customer ReadCustomerForCreate(Customer customer)
        {
            Console.Write("Enter FirstName :"); customer.FirstName=Console.ReadLine();
            Console.Write("Enter LastName :");customer.LastName=Console.ReadLine();
            Console.Write("Enter Age :");customer.Age=byte.Parse(Console.ReadLine()??"");    
            Console.Write("Enter Email :");customer.Email=Console.ReadLine();    
            return customer;
        }

        public Employee ReadCustomerForEmployee(Employee employee)
        {
            Console.Write("Enter FirstName :"); employee.FirstName = Console.ReadLine();
            Console.Write("Enter LastName :"); employee.LastName = Console.ReadLine();
            Console.Write("Enter Age :"); employee.Age = byte.Parse(Console.ReadLine() ?? "");
            Console.Write("Enter Email :"); employee.Email = Console.ReadLine();
            return employee;
        }
    }
}
