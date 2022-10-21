using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class Marks : DbContext
    {

        public Marks()
            : base("name=Marks")
        {
            Database.SetInitializer<Marks>(new CreateDatabaseIfNotExists<Marks>());
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Mark> MarkList { get; set; }

    }

    public class Mark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sno { get; set; }
        public int RollNo { get; set; }
        public int SubjectId { get; set; }
        public int marks { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }

    }

    public class Subject
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            this.marks = new HashSet<Mark>();
        }

        [Key]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Duration { get; set; } //minutes 
        public int ClassNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mark> marks { get; set; }
    }

    public class Student
    {

        public Student()
        {
            this.marks = new HashSet<Mark>();
        }
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public System.DateTime DOB { get; set; }
        public int ClassNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mark> marks { get; set; }
    }
}