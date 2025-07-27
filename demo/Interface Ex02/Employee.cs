 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Interface_Ex02
{
    internal class Employee : ICloneable , IComparable
    {
        public int id { get; set; }
        public string name { get; set; }
        public  int age { get; set; }
        public double salary { get; set; }

        public object Clone()
        {
            return new Employee() { id = this.id, name = this.name, age = this.age, salary = this.salary };
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee) obj;

            //if (this.age > e.age) return 333;
            //else if (this.age < e.age) return -333;
            //else return 0;

            return this.age.CompareTo(e.age); // becouse age is a int

        }

        public override string ToString()
        {
            return $"id : {id}, name : {name}, age : {age}, Salary : {salary}";
        }
    }

    class EmployeeComparerNameLength : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            if (X.name.Length > Y.name.Length) return 1;
            else if (X.name.Length < Y.name.Length) return -1;
            else return 0;
        }
    }

}
