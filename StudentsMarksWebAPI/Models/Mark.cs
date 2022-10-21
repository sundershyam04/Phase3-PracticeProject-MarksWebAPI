﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsMarksWebAPI.Models
{
    public class MMark
    {

        public int RollNo { get; set; }
        public int SubjectId { get; set; }
        public int marks { get; set; }

        public virtual MStudent Student { get; set; }
        public virtual MSubject Subject { get; set; }
    }
}