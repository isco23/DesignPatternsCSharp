using System;

namespace ProtoTypeDemo
{
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
}
