using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterDemo
{
    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            this.employees.Add(new Employee(1, "John"));
            this.employees.Add(new Employee(2, "Micheal"));
            this.employees.Add(new Employee(3, "Jason"));
        }

        public virtual string GetAllEmployees()
        {
            var serializer = new XmlSerializer(employees.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using(var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, employees);
                return stream.ToString();
            }
        }
    }
}
