using SchoolApp.Interface;
using SchoolApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> Students { get; set; } = new List<Student>
        {
            new Student { Id = 1, FirstName = "Ayo", LastName = "Adekunle", Email = "ay@gmail.com", Age = 56, Address = "Ikoyi"},
            new Student { Id = 2, FirstName = "Ade", LastName = "Adekunle", Email = "ade@gmail.com", Age = 6, Address = "Ikoyi"},
            new Student { Id = 3, FirstName = "Jola", LastName = "Balogun", Email = "joola@gmail.com", Age = 36, Address = "Ikoyi"},
            new Student { Id = 4, FirstName = "Ayo", LastName = "Adelek", Email = "ayo@gmail.com", Age = 26, Address = "Ikoyi"}
        };

        public void AddStudent(string firstName, string lastName, string email, int age, string address)
        {
            var Id = 5;
            var newStudent = new Student

            {
                Id = Id, FirstName = firstName, LastName = lastName, Email = email, Age = age, Address = address
            };
            if (Students.Contains(newStudent))
            {
                Console.WriteLine("Student already exists");
            };

            Students.Add(newStudent);

            Console.WriteLine($"{newStudent.LastName} {newStudent.FirstName} is registered");
        }
    }
}
