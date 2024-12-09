namespace MVC_CORE_ViewModelDemo2.Models
{
    //ViewModel is combination Student, Address models +
    //Extra properties like Title,Header
    public class StudentDetailsViewModel
    {
        public Student? Student { get; set; }
        public Address? Address { get; set; }
        //extra properties
        public string? Title { get; set; }
        public string? Header { get; set; }

    }
}
