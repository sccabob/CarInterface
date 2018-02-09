using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInterface
{
    //Properties and Methods common to all transmissions
    public interface ITransmission
    {
        //A method that is common to all transmission types
        void ShiftIntoGear();
        
        //A read only property for classifying types of transmissions
        string TransmissionType 
        {
            get;
        }
    }

}
