using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vall
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 employee = new Class1
            {
                Name = "aeris",
                Age = 25,
                UserName = "00xtz",
                Email = "xyz@",
                Password = "12376558",
                ConfirmPassword = "12345678",
                PhoneNumber = "(123)-(765)-(9085)",


            };

            Class2 tester = new Class2();
            tester.Test(employee);
        }
    }
}
