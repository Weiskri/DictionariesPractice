using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Syntax - Dictionary <key data type, value data type> dictionaryname
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry", 90 }, // "kerry is the key", 90 is the value (her grade)
                {"Barry", 85 },
                {"Michelle", 100 }
            }; 

        }
    }
}
