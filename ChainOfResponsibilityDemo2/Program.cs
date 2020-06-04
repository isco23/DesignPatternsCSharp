using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamLeader teamLeader = new TeamLeader();
            ProjectLeader projectLeader = new ProjectLeader();
            HR hr = new HR();
            teamLeader.setNextSupervisor(projectLeader);
            projectLeader.setNextSupervisor(hr);
            teamLeader.applyLeave("Anurag", 9);
            Console.WriteLine();
            teamLeader.applyLeave("Pranaya", 18);
            Console.WriteLine();
            teamLeader.applyLeave("Priyanka", 30);
            Console.WriteLine();
            teamLeader.applyLeave("Ramesh", 50);
            Console.Read();
        }
    }
}
