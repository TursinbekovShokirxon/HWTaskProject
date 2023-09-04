using Infrastructure.DBConfiguration;

namespace Infrastructure.DBInitialize
{
    public class Initialize
    {
        DBConnection dBConnection = new();
public static string database = @"
            create table if not exists customers(
            customer_id serial primary key,
            age int,
            email varchar,
            customerfirstname varchar,
            customerlastname varchar);
                        
            create table if not exists employees(
            employee_id serial primary key,
            age int,
            email varchar,
            employeefirstname varchar,
            employeelastname varchar);

            create table tasks(
            task_id serial primary key,
            customer_id integer references customers(customer_id),
            employee_id integer references employees(employee_id),
            Name varchar,
            Description varchar,
            DeadLine varchar,
            OrderDate varchar,
            Price real);";

        public void Init()
        {
            Task<int> tasks= dBConnection.ExecuteCommandAsync(database);
            tasks.Wait();
        }
    }
}
