using System.Globalization;

namespace ProductStore.Entities
{
    internal class UsedProduct : Product
    {


        public DateTime ManufatureDate { get; set; }



        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufatureDate) : base(name, price) { 
        
            ManufatureDate = manufatureDate;
        
        }


        public override string PriceTag()
        {
            return Name 
                + " (Used) $" 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + " (Manufature Date: " 
                + ManufatureDate.ToString("dd/MM/yyyy") + ")";


        }
    }
}
