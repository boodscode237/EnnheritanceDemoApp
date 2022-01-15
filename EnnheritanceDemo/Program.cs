using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnnheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Corolla corolla = new Corolla();

            SmartPhone smartPhone = new SmartPhone();
            LandLine landLine = new LandLine();

            List<Phone> phones = new List<Phone>();

            phones.Add(new SmartPhone());
            phones.Add(new SmartPhone());

            foreach (var phone in phones)
            {
                phone.PlaceCAll();
            }

            foreach (var phone in phones)
            {
                if (phone is CellPhone cell)
                {
                    cell.Carrier = "";
                }

                if (phone is SmartPhone smartPhone1)
                {
                    smartPhone1.ConnectToInternet();
                }
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
