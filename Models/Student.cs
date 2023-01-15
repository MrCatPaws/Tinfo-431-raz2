namespace ContosoUniversity.Models
{
    //jag9-raz1
    //Created the student class that creates 5 getters and setters
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
