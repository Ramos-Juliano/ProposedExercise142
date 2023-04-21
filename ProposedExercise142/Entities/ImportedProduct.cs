using System.Globalization;

namespace ProposedExercise142.Entities
{
    class ImportedProduct : Product
    {
        public double CunstomsFee { get; set; }

        public ImportedProduct() 
        {

        }

        public ImportedProduct(string name, double price,double cunstomsFee) :base (name, price)
        {            
            CunstomsFee = cunstomsFee;
        }

        public double TotalPrice()
        {
            return Price + CunstomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee: $" + CunstomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }        

    }

}
