using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.System.Models
{
    public class Loan
    {
        public Loan(string type, double interestRate)
        {
            Type = type;
            InterestRate = interestRate;
        }

        public string Type { get; set; }
        public double InterestRate { get; set; }
    }
}
