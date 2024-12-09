using Microsoft.AspNetCore.Mvc;
using MVC_CORE_ViewModelDemo2.Models;

namespace MVC_CORE_ViewModelDemo2.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Details()
        {
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Surya",
                Branch = "IT",
                Section = "A",
                Gender = "Male"
            };
            //Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Hyderabad",
                State = "Telangana",
                Country = "India",
                Pin = "500050"
            };
            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };
            //Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }

    }
}
