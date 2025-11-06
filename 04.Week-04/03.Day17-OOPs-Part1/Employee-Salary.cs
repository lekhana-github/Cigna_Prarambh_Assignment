// 3..  Write a c# program to implement the following requirements:
// 		a.  Create an Employee Class 
// 				Members:
// 							1. Properties:    Id, Name, Job, Basic, HRA,DA,IT,PF, GrossSalary
// 							2. Methods :     GetGrossSalary(), PrintDetails()
								
// 		-->   GrossSalary should calculate based on the following following requirements :
// 						Gross Salary  =  Basic +  HRA (15%)  + DA (8%)  - IT(10%) - PF(5%)
		
// 		-->  Read input from user :   Id, Name, Job, Basic
// 		--> Make sure that all options are working without fail. 
// 		--> Add extra properties to store HRA, DA, IT, PF, GrossSalary etc....

namespace ObjectOrientedProgramming
{


    internal class EmployeeSalaryDetails
    {

        class Employee
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public string Job { get; set; }
            public double Basic { get; set; }
            public double HRA { get; set; }
            public double DA { get; set; }
            public double IT { get; set; }
            public double PF { get; set; }
            public double GrossSalary { get; set; }


            public void GetGrossSalary()
            {
                HRA = 0.15 * Basic;
                DA = 0.08 * Basic;
                IT = 0.10 * Basic;
                PF = 0.05 * Basic;

                GrossSalary = Basic + HRA + DA - IT - PF;
            }

            public void PrintDetails()
            {
                Console.WriteLine("\n------ Employee Details ------");
                Console.WriteLine($"ID : {Id}");
                Console.WriteLine($"Name : {Name}");
                Console.WriteLine($"Job : {Job}");
                Console.WriteLine($"Basic Salary : {Basic}");
                Console.WriteLine($"HRA (15%) : {HRA}");
                Console.WriteLine($"DA (8%) : {DA}");
                Console.WriteLine($"IT (10%) : {IT}");
                Console.WriteLine($"PF (5%) : {PF}");
                Console.WriteLine($"Gross Salary : {GrossSalary}");
                Console.WriteLine("-------------------------------");
            }
        }
            static void Main(string[] args)
            {
                Employee emp = new Employee();
            
            Console.Write("Enter Employee ID: ");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Job Title: ");
            emp.Job = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            emp.Basic = Convert.ToDouble(Console.ReadLine());

            
            emp.GetGrossSalary();
            emp.PrintDetails();

            Console.ReadLine();



        }
        }
    }

