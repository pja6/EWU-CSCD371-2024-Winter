using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class JokeServiceOutput : IJokeServiceOutput
    {
        public void Write(string joke)
        {
            Console.WriteLine(joke);
        }
    }
}
