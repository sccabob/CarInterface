using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What type of Transmission would like in your Vehicle");




            Vehicle myVehicle = new Vehicle(new ManualTransmission());

            Console.WriteLine("This vehicle is equipped with a transmission of type " + myVehicle.TransmissionType.ToString());

            myVehicle.ShiftIntoGear();           
        }
    }
}
