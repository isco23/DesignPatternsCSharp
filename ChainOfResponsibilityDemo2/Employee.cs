using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo2
{
    public abstract class Employee
    {
        // next element in chain or responsibility
        protected Employee supervisor;
        public void setNextSupervisor(Employee supervisor)
        {
            this.supervisor = supervisor;
        }
        public abstract void applyLeave(string employeeName, int numberofDaysLeave);
    }
}
