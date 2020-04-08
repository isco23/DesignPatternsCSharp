using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            ShallowCopyRef();
        }

        public static void ShallowCopy()
        {
            Employee empJohn = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "John",
                DepartmentID = 150
            };
            Console.WriteLine(empJohn.ToString());

            Employee empSam = (Employee)empJohn.Clone();
            empSam.Name = "Sam Paul";
            Console.WriteLine(empSam.ToString());

            Console.WriteLine("Changed John DepartmentID to 161");

            empJohn.DepartmentID = 161;
            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());
            Console.ReadKey();
        }

        public static void ShallowCopyRef()
        {
            Employee empJohn = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "John",
                DepartmentID = 150,
                AddressDetails = new Address()
                {
                    DoorNumber = 10,
                    StreetNumber = 20,
                    ZipCode = 90025,
                    Country = "US"
                }
            };

            Console.WriteLine(empJohn.AddressDetails.StringCon());

            Employee empSam = (Employee)empJohn.DeepCopy();
            empSam.Name = "Sam Paul";
            empSam.DepartmentID = 151;
            empSam.AddressDetails.StreetNumber = 30;

            Console.WriteLine(empSam.AddressDetails.StringCon());

            Console.WriteLine("Modified Details for John");
            empJohn.AddressDetails.DoorNumber = 11;
            empJohn.DepartmentID = 160;
            Console.WriteLine(empJohn.AddressDetails.StringCon());
            Console.WriteLine(empSam.AddressDetails.StringCon());
            Console.ReadLine();
        }
    }
    public partial class Employee : CloneablePrototype<Employee>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public Address AddressDetails { get; set; }

        public string StringCon()
        {
            return string.Format("Name: {0} " + "DepartmentID : {1} ", this.Name, this.DepartmentID);
        }
    }

    //public partial class Employee : ICloneable
    //{
    //    public object Clone()
    //    {
    //        return this.MemberwiseClone();
    //    }
    //}

    public class Address
    {
        public Address()
        {

        }
        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }

        public string StringCon()
        {
            return string.Format("AddressDetails: Door : {0} "+" StreetNumber : {1} "+" ZipCode : {2} "+" Country : {3}", this.DoorNumber, this.StreetNumber, this.ZipCode, this.Country);
        }
    }

    public abstract class CloneablePrototype<T>
    {
        // Shallow Copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }
        // Deep Copy

        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
        
    }    
}
