using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_2023.Problem
{
    interface ILogger
    {
        void Handle(string error);
    }
    class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
    class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }

    class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }

    public class AddCustomerLogger
    {
        private ILogger obj;
        public void Add(int Exhandle)
        {
             
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                if (Exhandle == 1)
                {
                    obj = new FileLogger();
                }
                else
                {
                    obj = new EmailLogger();
                }
                obj.Handle(ex.Message.ToString());
            }
        }
    }

}
