namespace OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //Employees employees = new Employees(101, "Youssef El-Anwar", SEcurityLevel.DBA, 15000.75m, Gender.M);
            //Console.WriteLine(employees.ToString());
            //HiringDate hiringDate = new HiringDate(15, 3, 2023);
            //Console.WriteLine($"Date : {hiringDate.ToString()}");

            #endregion

            #region Question 02
            Employees[] EmpArr = new Employees[3];
            
            // Create Employees
            EmpArr[0] = new Employees(1, "Ali", SEcurityLevel.DBA, 20000, Gender.M, new HiringDate(5, 7, 2023));
            EmpArr[1] = new Employees(2, "Sara",SEcurityLevel.Guest, 5000, Gender.F, new HiringDate(10, 6, 2022));
            EmpArr[2] = new Employees(3, "Omar",SEcurityLevel.Developer, 15000, Gender.M, new HiringDate(1, 1, 2021));

            // Display all employees
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
        }

            #endregion
        }
    }

