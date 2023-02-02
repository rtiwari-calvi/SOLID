using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_2023.Solution
{
    public class DiscountLSP
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }

        public virtual void Add()
        {
            //do something
        }
    }

    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }


    interface IDatabase
    {
        void Add();
    }

    class SilverCustomerDiscountLSP : IDiscount, IDatabase
    {
        public  double getDiscount(double TotalSales)
        {
            return TotalSales - 50;
        }

        public  void Add()
        {
            //do something
        }
    }

    class goldCustomerDiscountLSP : IDiscount, IDatabase
    {
        public  double getDiscount(double TotalSales)
        {
            return TotalSales - 100;
        }
        public  void Add()
        {
            //do something
        }
    }

    public class EnquiryLSP : IDiscount
    {
        public  double getDiscount(double TotalSales)
        {
            return TotalSales - 100;
        }

    }

    public class TestLSP
    {
        public void RunAdd()
        {
            List<IDiscount> Customers = new List<IDiscount>();
            Customers.Add(new SilverCustomerDiscountLSP());
            Customers.Add(new goldCustomerDiscountLSP());
            Customers.Add(new EnquiryLSP());

            foreach (IDiscount o in Customers)
            {
                o.getDiscount(50);
            }
        }

        public void RunDiscount()
        {
            List<IDatabase> Customers = new List<IDatabase>();
            Customers.Add(new SilverCustomerDiscountLSP());
            Customers.Add(new goldCustomerDiscountLSP());
            Customers.Add(new EnquiryLSP());

            foreach (IDatabase o in Customers)
            {
                o.Add();
            }
        }
    }
}
