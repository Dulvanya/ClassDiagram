﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class Department
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Course> Courses { get; set; }

        public List<Professor> Professors { get; set; }


        public Department(string Name, string Code) 
        { 
            this.Name = Name;
            this.Code = Code;
        }

        public void AddCourse()
        {

        }

        public void AddProfessor()
        {

        }

        public void AddStudent()
        {

        }

    }
}
