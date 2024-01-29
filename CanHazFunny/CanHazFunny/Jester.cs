using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
   
    public class Jester(IJokeService jokeService, IJokeServiceOutput outputInterface)
    {
        private readonly IJokeService _jokeService = jokeService ?? throw new ArgumentNullException(nameof(jokeService));
        private readonly IJokeServiceOutput _outputInterface = outputInterface ?? throw new ArgumentNullException(nameof(outputInterface));

        public string TellJoke()
        {
            return _jokeService.getJoke();
        }




    }//end of class

 
}
