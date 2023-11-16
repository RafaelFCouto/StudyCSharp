using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace InterfacesStudy.Entities
{
    internal class RentalCar
    {
        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }

        public Invoice Invoice { get; set; }

        public RentalCar(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
