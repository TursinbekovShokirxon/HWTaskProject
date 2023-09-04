using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class People
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set ; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public override string ToString()
        {
            return $"Id :{Id}\nFirstName :{FirstName}\nLastName :{LastName}\nEmail :{Email}";
        }
    }
}
