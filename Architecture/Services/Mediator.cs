using Application.Interface;
using Application.Services;
using Domain.Models;
using Infrastructure.DBConfiguration;

namespace WebUI.Services
{
    public class Mediator : InterfaceForCrudCustomer
    {
        public static Read? read;
        public static DbCustomer? dbCustomer;
        public Mediator()
        {
            read=new();
            dbCustomer = new();
        }
        public void Create()
        {
            Customer customer = new Customer();
            customer = read.ReadCustomerForCreate(customer);
            Task<bool> isCompleted = dbCustomer.Create(customer);
            isCompleted.Wait();
        }
        public void Delete()
        {
            ReadAll();
            IList<Customer> list = (IList<Customer>)GetAll();
            Console.WriteLine("Enter Id which one you want delete");
            int id = int.Parse(Console.ReadLine() ?? "");
            Customer ById = list.Where(i => i.Id == id).FirstOrDefault();
            if (ById!=null) dbCustomer.Delete(ById.Id);
            else Console.WriteLine($"{id} not exist");
        }
        public IEnumerable<Customer> GetAll()
        {
            IEnumerable<Customer> list = (IEnumerable<Customer>)dbCustomer.GetAll();
            return list;
        }
        public void GetById()
        {
            IList<Customer> list = (IList<Customer>)GetAll();
            Console.WriteLine("Enter Id which one you see");
            int id = int.Parse(Console.ReadLine() ?? "");
            Customer ById = list.Where(i => i.Id == id).FirstOrDefault();
            if (ById!=null) { Console.WriteLine(ById.ToString()); }
            else Console.Out.WriteLineAsync($"{id} not exist");
        }
        public void Update()
        {
            ReadAll();
            IList<Customer> list = (IList<Customer>)GetAll();
            Console.WriteLine("Enter Id which one you want Update");
            int id = int.Parse(Console.ReadLine() ?? "");
            Customer ById = list.Where(i => i.Id == id).FirstOrDefault();
            if (ById!=null)
            {
                ById = read.ReadCustomerForCreate(ById);
                dbCustomer.Update(ById);
            }
            else Console.WriteLine($"{id} not exist");
        }
        public void ReadAll()
        {
            IEnumerable<Customer> list = GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
