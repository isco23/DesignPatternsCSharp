using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterDemo
{
    [Serializable]
    public class Employee
    {
        Employee() { }

        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
