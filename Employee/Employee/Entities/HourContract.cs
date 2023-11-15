

namespace Employee.Entities
{
    internal class HourContract
    {

        public DateTime Date {  get; set; }
        public double ValuePerHour { get; set; }

        public int Hours {  get; set; }


        public HourContract() { }

        public HourContract (double valuePerHour, int hours)
        {
            ValuePerHour = valuePerHour;
            Hours = hours;

        }

        public HourContract (double valuePerHour, int hours, DateTime date): this (valuePerHour, hours) { 
            
            Date = date;
        
        }





        public double TotalValue()
        {

            double salary = ValuePerHour * Hours;
            return salary;

        }






    }
}
