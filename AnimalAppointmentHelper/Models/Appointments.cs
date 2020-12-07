using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAppointmentHelper.Models
{
    public class Appointments
    {
       // public int AppointmentId { get; set; }
        public string Name { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Symptoms { get; set; }

        public string AppointmentsInformation
        {
            get
                {
                 return string.Format("Appointments: {0}, {1}, {2}, {3}, {4}", this.Name, this.Month, this.Day, this.Time, this.Symptoms);
            }
        }
    }

    

}
