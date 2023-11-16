
using System.Security.Principal;

namespace LogAccess.Entities
{
    internal class LogRecord
    {

        public string Name { get; set; }
        public DateTime Moment { get; set; }

        public LogRecord(string name, DateTime moment)
        {
            Name = name;
            Moment = moment;
        }



        public override int GetHashCode()
        {
            return Name.GetHashCode() ;

        }

        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord))
            {
                return false;
            }

            LogRecord other = obj as LogRecord;

            return Name.Equals(other.Name) ;

        }
    }
}
