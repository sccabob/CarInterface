using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInterface
{
    class Vehicle 
    {
        private readonly ITransmission _transmission;

        public Vehicle (ITransmission transmission)
        {
            _transmission = transmission;
            _transMissionType = transmission.TransmissionType;
        }

        public void ShiftIntoGear()
        {
            _transmission.ShiftIntoGear();
        }

        private String _transMissionType;

        public String TransmissionType
        {
            get { return _transMissionType; }
        }


    }
}
