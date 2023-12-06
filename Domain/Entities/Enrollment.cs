using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Enrollment
    {
        public Guid EnrollmentId { get; set; }

        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
