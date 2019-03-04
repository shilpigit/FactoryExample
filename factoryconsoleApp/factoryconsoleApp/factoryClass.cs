using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryconsoleApp
{
    interface Ifactory
    {
        void details();
    }


    class PermanentEmployee: Ifactory
    {
        public void details()
        {
            Console.WriteLine("Permanent Employee");
        }
    }

    class TemporaryEmployee: Ifactory
    {
        public void details()
        {
            Console.WriteLine("Temporary Employee");
        }
    }

    abstract class EmployeeFactory
    {
        public abstract Ifactory Factory(string Employee);
    }
    class factoryClass
    {
    }
}
