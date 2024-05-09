using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.System.Models.LoanService
{
    public static class LoanService
    {
        public static List<Loan> PossibilitiesOfLoans(Request request)
        {
            var responseList= new List<Loan>();

            if (request.Income <= 3000||(request.Income>3000 && request.Income<5000)||(request.Age<30 && request.Location=="SP"))
            {
                responseList.Add(new Loan("PERSONAL", 4.0));
                responseList.Add(new Loan("GUARANTEED", 3.0));
            }
            if (request.Income >= 5000)
            {
                responseList.Add(new Loan("CONSIGNMENT", 2.0));
            }
            return responseList;
        }
    }
}
