using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        private int departmentPerformance;

        public int DepartmentPerformance
        {
            get { return this.departmentPerformance; }
            set
            {
                if (value < 0)
                    this.departmentPerformance = 0;
                else
                    this.departmentPerformance = value;
            }
        }

        public Manager(string id, string name, int baseSalary, int departmentPerformance)
            : base(id, name, baseSalary)
        {
            this.departmentPerformance = departmentPerformance;
        }

        public Manager(string id, string name, string baseSalary, string departmentPerformance)
            : this(id, name, int.Parse(baseSalary), int.Parse(departmentPerformance))
        { }

        public override double BaseSalary
        {
            get { return base.BaseSalary; }
            set
            {
                if (value > 120000)
                    base.baseSalary = 120000;
                else if (value >= 50000 && value <= 120000)
                    base.baseSalary = value;
                else
                    base.baseSalary = 50000;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n部門績效:{0}\n總薪資:{1}"
                , this.DepartmentPerformance, this.BaseSalary + this.DepartmentPerformance);
        }
    }
}