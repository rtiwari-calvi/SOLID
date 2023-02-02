
namespace Solid_2023.Solution
{
    interface IDiscountISP
    {
        double getDiscount(double TotalSales);
    }


    interface IDatabaseISP
    {
        void Add();
   
    }
    interface IDatabaseISPv2 : IDatabaseISP
    {

        void Read();
    }
    class SilverCustomerDiscountISP : IDiscountISP, IDatabaseISP
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 50;
        }

        public void Add()
        {
            //do something
        }

        public void Read()
        {
            //do something
        }
    }

    class goldCustomerDiscountISP : IDiscountISP, IDatabaseISPv2
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 100;
        }
        public void Add()
        {
            //do something
        }

        public void Read()
        {
            //do something
        }
    }

    public class EnquiryISP : IDiscountISP
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 100;
        }

    }
}
