using Domain.Models;
using Infrastructure.Connection.Interface;
using Npgsql;

namespace Infrastructure.DBConfiguration
{
    public class DbCustomer : InterfaceDBCustomer
    {
        public static string connect = @"Server=localhost;Port=5432;Database=new;User id=postgres;password=adminadmin";
        public DBConnection _dbConnect = new();
        public async Task<bool> Create(Customer type)
        {
            string command = $@"insert into customers(first_name,last_name,age,email) values('{type.FirstName}','{type.LastName}',{type.Age},'{type.Email}')";
            int effect = await _dbConnect.ExecuteCommandAsync(command);
            return effect > 0;
        }
        public async Task<bool> Delete(int id)
        {
            string command = $@"delete from customers where customer_id={id}";
            int effect = await _dbConnect.ExecuteCommandAsync(command);
            return effect > 0;
        }
        public async Task<IEnumerable<Customer>> GetAll()
        {
            IList<Customer> Customers = new List<Customer>();
            string command = "select * from customer;";
            NpgsqlDataReader reader = await _dbConnect.ExecuteQueryAsync(command);
            while (reader.Read())
            {
                Customers.Add(new()
                {
                    Id = (int)reader["customer_id"],
                    Age = (int)reader["age"],
                    Email = (string)reader["email"],
                    FirstName = (string)reader["customerfirstname"],
                    LastName = (string)reader["customerlastname"]
                });
            }
            reader.Close();
            return Customers;
        }
        public async Task<Customer> GetById(int id)
        {
            List<Customer> customers = (List<Customer>)await GetAll();
            Customer ById = customers.Where(x => x.Id == id).FirstOrDefault();
            return ById;
        }
        public async Task<bool> Update(Customer type)
        {
            string command = $@"Update customers set customerfirstname='{type.FirstName}',customerlastname='{type.LastName}',age={type.Age},email='{type.Email}' where customer_id={type.Id}";
            int effect = await _dbConnect.ExecuteCommandAsync(command);
            return effect > 0;
        }
    }
}
