using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo3
{
    public interface ITarget
    {
        string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
    }
}
