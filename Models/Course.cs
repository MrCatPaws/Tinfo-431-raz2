using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversity.Models
{

    //jag9-raz1
    //Creates a class named Course and creates 4 getters and setters
    //The DatabaseGenerated() method allows the app to generate the 
    //primary key for the database instead of the database creating it
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } 
    }
}