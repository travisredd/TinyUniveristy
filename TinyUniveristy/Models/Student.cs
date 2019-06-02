using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyUniveristy.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigation Properties

        public ICollection<Enrollment> Enrollments {get; set; }
    }
}
