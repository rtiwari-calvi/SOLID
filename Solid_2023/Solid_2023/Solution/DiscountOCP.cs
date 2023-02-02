

namespace Solid_2023.Solution
{
    public class Discount
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    class SilverCustomerDiscount : Discount
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }
    }

    class goldCustomerDiscount : Discount
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }
}
