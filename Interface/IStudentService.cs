using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Interface
{
    public interface IStudentService
    {
        void AddStudent(string fistName, string lastName, string email, int age, string address);
    }
}
