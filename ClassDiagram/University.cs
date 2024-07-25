using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class University
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Department>departments { get; set; }

        public University(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void AddDepartmen(Department dep)
        {

            departments.Add(dep);
        }

        public List<Department> GetDepartments() 
        {
            return departments;
        }


    }
}