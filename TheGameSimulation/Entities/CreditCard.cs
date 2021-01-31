using System;
using System.Collections.Generic;
using System.Text;
using TheGameArchitect.Abstract;

namespace TheGameSimulation.Entities
{
    class CreditCard
    {
        class CreditCard : ISale
        {
            public int Id { get; set; }
            public string SaleMethodName { get; set; }
            public string CardNumber { get; set; }
            public string Cvv { get; set; }
            public double SaleAmount { get; set; }
        }
    }
}
