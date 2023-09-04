using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Connection.Interface
{
    public interface InterfaceDBConnection
    {
        public Task<int> ExecuteCommandAsync(string command);
        public Task<NpgsqlDataReader> ExecuteQueryAsync(string query);
    }
}
