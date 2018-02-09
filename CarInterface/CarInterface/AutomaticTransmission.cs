using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInterface
{
    class AutomaticTransmission : ITransmission
    {
        public void ShiftIntoGear()
        {
            Console.WriteLine("Depress Brake");
            Console.WriteLine("Select 'Drive'");
            Console.WriteLine("Release Brake");
            Console.ReadLine();
        }

        private String _transmissionType = "Automatic";

        public String TransmissionType
        {
            get { return _transmissionType; }
        }
    }
}
