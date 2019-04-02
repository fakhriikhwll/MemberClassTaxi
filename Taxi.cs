using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        public string DriveName {get; set;}
        public bool OnDuty {get; set;}
        public int NumPassenger { get; set;}

        public void TaxiInfo()
        {
            Console.WriteLine("Drive Name : {0}", DriveName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Number of Passenger : {0}\n", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriveName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriveName);
        }
    }
}
