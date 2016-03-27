using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string id, string name, int baseSalary)
        {
            this.Id = id;
            this.Name = name;
            this.BaseSalary = baseSalary;
        }

        public Employee(string id, string name, string baseSalary)
            : this(id, name, int.Parse(baseSalary))
        {
        }

        public string Name { get; set; }
        public string Id { get; set; }
        protected double baseSalary;

        virtual public double BaseSalary
        {
            get { return this.baseSalary; }
            set
            {
                if (value > 50000)
                    this.baseSalary = 50000;
                else if (value >= 22000 && value <= 50000)
                    this.baseSalary = value;
                else
                    this.baseSalary = 22000;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("員工編號:{0}, 姓名:{1}\n",
                this.Id, this.Name);
            result += string.Format("基本薪資:{0}", this.BaseSalary);
            return result;
        }
    }
}