using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    //jag9-raz1
    //Creates a public enum named Grade and creates a class named
    //Enrollment that declares 6 getters and setters
    //Grade is nullable meaning it has the option of containing
    //a value type of null or a type that is not null
    public enum Grade
    {
        A, B, C, D, F 
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}