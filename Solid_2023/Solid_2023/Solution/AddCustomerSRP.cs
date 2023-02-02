

namespace Solid_2023.Solution
{
    public class AddCustomer
    {
        private FileLogger obj = new FileLogger();
        public  void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());
            }
        }
    }

    public class FileLogger
    {
        public void Handle(string error)
        {
            File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
