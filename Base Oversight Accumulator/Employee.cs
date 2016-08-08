using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Oversight_Accumulator
{
    class Employee
    {
        public Employee(int empid, string empname, string empdept)
        {
            this.empId = empid;
            this.empName = empname;
            this.empDept = empdept;
        }

        private int empId;

        public int Empid
        {
            get { return empId; }
            set { empId = value; }
        }

        private string empName;

        private string EmpName
        {
            get { return EmpName; }
            set { EmpName = value; }
        }

        private string empDept;

        public string EmpDept
        {
            get { return empDept; }
            set { empDept = value; }
        }
    }
}
