using Domain.Models;
using Infrastructure.Connection.Interface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DBConfiguration
{
    public class DBConnection: InterfaceDBConnection
    {
        public static string ConnectionString = @"Server=localhost;Port=5432;Database=new;User id=postgres;password=adminadmin";
        public async Task<int> ExecuteCommandAsync(string command)
        {
            int EffectRows = 0;
            using NpgsqlConnection connection = new(ConnectionString);
            connection.Open();
            NpgsqlCommand npgsqlCommand = new(command, connection);
            EffectRows = npgsqlCommand.ExecuteNonQuery();
            connection.Close();
            return EffectRows;
        }
        public async Task<NpgsqlDataReader> ExecuteQueryAsync(string query)
        {
            using NpgsqlConnection connection = new(ConnectionString);
            connection.Open();
            NpgsqlCommand npgsqlCommand = new(query, connection);
            NpgsqlDataReader reader = await npgsqlCommand.ExecuteReaderAsync();
            connection.Close();
            return reader;
        }
    }
}
