namespace TinyUniveristy.Models
{
    public enum Grade
        {
        A, B, C, D, E
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID {get; set;}
        public int CourseID { get; set; }
        public Grade? Grade { get; set; }

        //Navigation Properties

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}