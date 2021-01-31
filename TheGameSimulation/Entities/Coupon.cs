using System;
using System.Collections.Generic;
using System.Text;
using TheGameArchitect.Abstract;

namespace TheGameSimulation.Entities
{
    class Coupon
    {
        class Coupon : ISale
        {
            public int Id { get; set; }
            public string SaleMethodName { get; set; }
            public string CouponNumber { get; set; }
            public double SaleAmount { get; set; }
        }
    }
}
