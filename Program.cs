using DataAnnotationTask.Data;
using DataAnnotationTask.Models;
using System;
using System.Linq;

namespace DataAnnotationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            Department department = new Department();

            Console.WriteLine("Name Is: ");
            department.Name = Console.ReadLine();

            context.Departments.Add(department);

            context.SaveChanges();

        }
    }
}
