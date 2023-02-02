
namespace Solid_2023.Problem
{

    public class Discount1
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

    class SilverCustomerDiscount1 : Discount1
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }

        public override void Add()
        {
            //do something
        }
    }

    class goldCustomerDiscount1 : Discount1
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
        public override void Add()
        {
            //do something
        }
    }

    public class Enquiry1 : Discount1
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
        public override void Add()
        {
            throw new Exception("Not allowed");
        }
    }

    public class Test1
    {
        public void Run()
        {
            List<Discount1> Customers = new List<Discount1>();
            Customers.Add(new SilverCustomerDiscount1());
            Customers.Add(new goldCustomerDiscount1());
            Customers.Add(new Enquiry1());

            foreach (Discount1 o in Customers)
            {
                o.Add();
            }
        }
    }
}
