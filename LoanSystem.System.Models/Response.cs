using System;
using System.Collections.Generic;

namespace LoanSystem.System.Models
{
    public class Response
    {
        public Response(Request request)
        {
            Customer = request.Name;
            Loans = LoanService.LoanService.PossibilitiesOfLoans(request);
        }

        public Response(string customer, List<Loan> loans)
        {
            Customer = customer;
            Loans = loans;
        }

        public Response()
        {
            
        }
        public string Customer { get; set; }
        public List<Loan> Loans { get; set; }



        
    }
}
