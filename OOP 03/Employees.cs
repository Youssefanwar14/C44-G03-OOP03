using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    // Enums for Gender and Security Level
    public enum Gender
    {
        M,
        F
    }

    public enum SEcurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }


    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SEcurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public HiringDate HiringDate { get; set; }

        // Constructor
        public Employees(int id, string name, SEcurityLevel securityLevel, decimal salary, Gender gender, HiringDate hiringDate)
        {
            Id = id;
            Name = name ?? "Unknown";
            SecurityLevel = securityLevel;
            Salary = (salary >= 0) ? salary : 0;
            Gender = gender;
            HiringDate = hiringDate ?? new HiringDate(1, 1, 2000);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Gender: {Gender}, Hiring Date: {HiringDate}";
        }
    }
}

