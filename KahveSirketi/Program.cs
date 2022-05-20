using KahveSirketi.Abstract;
using KahveSirketi.Adapters;
using KahveSirketi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSirketi
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1990, 3, 16), FirstName = "Betül Nur", LastName = "Kalpaklıoğlu", NationalityId = "61660222836" });
            Console.ReadLine();
        }
    }
}
