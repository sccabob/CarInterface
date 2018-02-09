using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInterface
{
    class ManualTransmission : ITransmission
    {
        public void ShiftIntoGear()
        {
            Console.WriteLine("Depress Clutch");
            Console.WriteLine("Select Low Gear");
            Console.WriteLine("SLOWLY Release Clutch");
            Console.ReadLine();
        }

        private String _transmissionType = "Manual";

        public String TransmissionType
        {
            get { return _transmissionType; }
        }
    }
}
