

namespace Solid_2023.Solution
{
    public interface ILoggerDIP
    {
        void Handle(string error);
    }
    public class FileLoggerDIP : ILoggerDIP
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
    public class EverViewerLoggerDIP : ILoggerDIP
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }

    public class EmailLoggerDIP : ILoggerDIP
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }

    public class AddCustomerLoggerDIP
    {
        private ILoggerDIP _obj;
        public AddCustomerLoggerDIP(ILoggerDIP obj)
        {
            _obj= obj;
        }
        
        public void Add()
        {

            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                _obj.Handle(ex.Message.ToString());
            }
        }
    }
}
