using System.Globalization;

namespace ProductStore.Entities
{
    internal class ImportedProduct : Product
    {


        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            
            CustomsFee = customsFee;
        
        
        }

        public double TotalPrice()
        {
            double totalPrice = Price + 20;

            return totalPrice;
        }

        public override string PriceTag()
        {
            return  Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs Fee: $ " 
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) 
                +")";

        }
                  






    }
}
