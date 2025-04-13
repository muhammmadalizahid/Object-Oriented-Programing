using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1.UI
{
    class StaffUI : PersonUI
    {
        public static Staff takeStaffInfo()
        {
            Person basePerson = PersonUI.takePersonInfo();
            Console.WriteLine("Enter school: ");
            string school = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Staff staff = new Staff(basePerson.Name, basePerson.Address, school, salary);
            Staff.addToList(staff);
            return staff;
        }
    }
}
