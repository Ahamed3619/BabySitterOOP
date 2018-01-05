using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter
{
    class BabySitter
    {
       
       public List<Employee> AllEmployee = new List<Employee>();
       public void InitialEmployee()
       {
            Console.WriteLine("************* Welcome to Baby Sitter Application ***********");
            AllEmployee.Add(
                new Employee
                {
                    Name = "Rahim",
                    PhoneNumber = "01987654234",
                    address="51/A/3 WestRazabazr, Dhaka",
                    myObject1 = new EmergencyContact
                    {
                        Name = "Rana",
                        PhoneNumber = "0196783459876",
                        Relationship = "Cousin"
                    },
                    AllChild = new List<Child>
                    {
                        new Child{ Name="Babu", age=5, HealthInfo="Good", Interest="Badminton" }
                    }
                });

            AllEmployee.Add(
                new Employee
                {
                    Name = "Karim",
                    PhoneNumber = "01987654234",
                    address = "51/A/3 WestRazabazr, Dhaka",
                    myObject1 = new EmergencyContact
                    {
                        Name = "Jasim",
                        PhoneNumber = "0196783459876",
                        Relationship = "Brother"
                    },
                    AllChild = new List<Child>
                    {
                        new Child{ Name="Babu", age=5, HealthInfo="Good", Interest="Badminton" }
                    }
                });

        }
    
        public void User()
        {
           
            Console.WriteLine("\n\t\t0. Add a New Employee\n \t\t1. Remove an Employee\n \t\t2. Watch Employee Details ");
            Console.Write("Enter Your Input: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 0)
            {
                Add();
            }
            else if(userInput == 1)
            {
                Remove();
            }
            else if(userInput == 2)
            {
                Watch();
                WatchDetails();
            }
            else
            {
                Console.WriteLine("Wrong Choice. Try Again");
                User();
            }
        }
        public void Watch()
        {
            Console.WriteLine("Serial\tName\t\tAddress\t\t\tPhoneNumber");
            int i = 0;
            foreach(Employee myvalue in AllEmployee)
            {
                Console.WriteLine(++i+"\t"+myvalue.Name+"\t"+myvalue.address+"\t"+myvalue.PhoneNumber);
            }
            
           
        }
        public void WatchDetails()
        {
            Console.Write("Enter Serial Number to watch Details of the Employee: ");
            var WatchInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEmployee: ");
            Console.WriteLine("Serial\tName\t\tAddress\t\t\tPhoneNumber");
            Console.WriteLine(WatchInput + "\t" + AllEmployee[WatchInput-1].Name + "\t" + AllEmployee[WatchInput - 1].address + "\t" + AllEmployee[WatchInput - 1].PhoneNumber);

            Console.WriteLine("\nEmergency Contact Details: ");
            Console.WriteLine("Name\tPhone-Number\tRelation");
            Console.WriteLine(AllEmployee[WatchInput-1].myObject1.Name+"\t"+ AllEmployee[WatchInput - 1].myObject1.PhoneNumber + "\t" + AllEmployee[WatchInput - 1].myObject1.Relationship);

            Console.WriteLine("\nChild Details: ");
            Console.WriteLine("Name\tAge\tHealth\tInterest");
            foreach(var mychild in AllEmployee[WatchInput-1].AllChild )
            {
                Console.WriteLine(mychild.Name+"\t"+mychild.age+"\t"+mychild.HealthInfo+"\t"+mychild.Interest);
            }

            User();
        }
        public void Add()
        {
            Console.Write("Enter EmployeeName: ");
            var NewEmployee = Console.ReadLine();
            Console.Write("Enter Employee Phone: ");
            var EmployeePhoneNumber = Console.ReadLine();
            Console.Write("Enter Employee Address: ");
            var EmployeeAddress = Console.ReadLine();

            Console.Write("Enter Emergency Person Name: ");
            var EmergencyPersonName = Console.ReadLine();
            Console.Write("Enter Emergency Contact: ");
            var EmergencyPhoneNumber = Console.ReadLine();
            Console.Write("Enter Relationship: ");
            var Relationship = Console.ReadLine();

            Console.Write("Enter Child Name: ");
            var ChildName = Console.ReadLine();
            Console.Write("Enter Child Age: ");
            var Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Health Info: ");
            var Health = Console.ReadLine();
            Console.Write("Enter Interest of the Child: ");
            var NewInterest = Console.ReadLine();
            AllEmployee.Add(
                new Employee
                {
                    Name = NewEmployee,
                    PhoneNumber = EmployeePhoneNumber,
                    address = EmployeeAddress,
                    myObject1 = new EmergencyContact
                    {
                        Name = EmergencyPersonName,
                        PhoneNumber = EmergencyPhoneNumber,
                        Relationship = Relationship
                    },
                    AllChild = new List<Child>
                    {
                        new Child{ Name=ChildName, age=Age, HealthInfo=Health, Interest=NewInterest }
                    }
                });
            User();
        }
        public void Remove()
        {
            Watch();
            Console.Write("Enter Serial to Delete The Employee: ");
            var DeleteInput = Convert.ToInt32(Console.ReadLine());
            AllEmployee.RemoveAt(DeleteInput - 1);
            User();
        }
    }
}
