using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.System.Models
{
    public class Request
    {
        public Request(int age, string cpf, string name, double income, string location)
        {
            Age = age;
            Cpf = cpf;
            Name = name;
            Income = income;
            Location = location;
        }

        public int Age { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public double Income { get; set; }
        public string Location { get; set; }
    }
}
