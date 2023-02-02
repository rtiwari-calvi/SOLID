
namespace Solid_2023.Problem
{

        interface IDiscount1
        {
            double getDiscount(double TotalSales);
        }


        interface IDatabase1
        {
            void Add();
            void Read();
        }

        class SilverCustomerDiscountLSP1 : IDiscount1, IDatabase1
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

        class goldCustomerDiscountLSP1 : IDiscount1, IDatabase1
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

        public class EnquiryLSP1 : IDiscount1
        {
            public double getDiscount(double TotalSales)
            {
                return TotalSales - 100;
            }

        }
    
}
