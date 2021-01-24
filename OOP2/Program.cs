using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealClient client1 = new RealClient();
            client1.ClientNumber = "12345";
            client1.FirstName = "Oguzhan";
            client1.LastName = "Bilgic";
            client1.IdentityNo = "12345678910";


            CorporateClient client2 = new CorporateClient();
            client2.Id = 2;
            client2.ClientNumber = "54321";
            client2.CompanyName = "Keove";
            client2.TaxNo = "1234567890";

            Client client3 = new RealClient();
            Client client4 = new CorporateClient();

            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Add(client1);
            customerManeger.Add(client2);

        }
    }
}
