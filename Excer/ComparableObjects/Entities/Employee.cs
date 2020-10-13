using System;
using System.Globalization;

namespace ComparableObjects.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
       }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
        // Método de IComparable
        public int CompareTo(object obj)
        {
            if(!(obj is Employee)) // se não Employee 
            {
                throw new ArgumentException("Erro ao comparar: argumento não é funcionário");
            }
            Employee other = obj as Employee; // obj é funcionário - downcasting
            return Name.CompareTo(other.Name); // ou Salary
        }
    }
}
