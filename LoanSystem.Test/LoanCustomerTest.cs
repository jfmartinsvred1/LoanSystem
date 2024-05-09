using LoanSystem.System.Models;
using System.Net;
using System.Net.Http.Json;

namespace LoanSystem.Test
{
    public class LoanCustomerTest
    {
        [Fact]
        public async Task Loans_PersonalAndGuaranteed()
        {
            //Arrange
            var listOfLoans = new List<Loan>
            {
                new Loan("PERSONAL", 4.0),
                new Loan("GUARANTEED", 3.0)
            };

            var request = new Request(26, "183.598.557.22", "João Victor Fernandes Martins", 2000, "RJ");

            var responseExpected = new Response();

            responseExpected.Customer = request.Name;
            responseExpected.Loans = listOfLoans;
            
            //Act
            var response = new Response(request);
            //Assert
            Assert.Equal(responseExpected.Loans.FirstOrDefault().Type,response.Loans.FirstOrDefault().Type);
            Assert.Equal(responseExpected.Loans.LastOrDefault().Type,response.Loans.LastOrDefault().Type);
            Assert.Equal(2,response.Loans.Count);
        }
        [Fact]
        public async Task Loans_Consignment()
        {
            //Arrange
            var listOfLoans = new List<Loan>
            {
                new Loan("CONSIGNMENT", 2.0)
            };

            var request = new Request(26, "183.598.557.22", "João Victor Fernandes Martins", 6000, "RJ");

            var responseExpected = new Response();

            responseExpected.Customer = request.Name;
            responseExpected.Loans = listOfLoans;

            //Act
            var response = new Response(request);
            //Assert
            Assert.Equal(responseExpected.Loans.FirstOrDefault().Type, response.Loans.FirstOrDefault().Type);
            Assert.Equal(responseExpected.Loans.LastOrDefault().Type, response.Loans.LastOrDefault().Type);
            Assert.Equal(1, response.Loans.Count);
        }
        [Fact]
        public async Task Loans_ConsignmentAndPersonalAndGuaranted()
        {
            //Arrange
            var listOfLoans = new List<Loan>
            {
                 new Loan("PERSONAL", 4.0),
                new Loan("GUARANTEED", 3.0),
                new Loan("CONSIGNMENT", 2.0)
            };

            var request = new Request(26, "183.598.557.22", "João Victor Fernandes Martins", 6000, "SP");

            var responseExpected = new Response();

            responseExpected.Customer = request.Name;
            responseExpected.Loans = listOfLoans;

            //Act
            var response = new Response(request);
            //Assert
            Assert.Equal("PERSONAL", response.Loans.Find(t=>t.Type=="PERSONAL").Type);
            Assert.Equal("GUARANTEED", response.Loans.Find(t => t.Type == "GUARANTEED").Type);
            Assert.Equal("CONSIGNMENT", response.Loans.Find(t => t.Type == "CONSIGNMENT").Type);
            Assert.Equal(3, response.Loans.Count);
        }
    }
}