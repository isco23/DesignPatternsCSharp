namespace Prototype2Demo
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }
        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }


        // For Deep Copy
        //public Employee GetClone()
        //{
        //    Employee employee = (Employee)this.MemberwiseClone();
        //    employee.EmpAddress = EmpAddress.GetClone();
        //    return employee;
        //}
    }
}
