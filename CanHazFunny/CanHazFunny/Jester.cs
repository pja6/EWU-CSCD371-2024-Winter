using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester 
    {
        private readonly IJokeService _jokeService;
        private readonly IOutputInterface _outputInterface;

        public Jester(IJokeService jokeService, IOutputInterface outputInterface)
        {
            _jokeService = jokeService ?? throw new ArgumentNullException(nameof(jokeService));
            _outputInterface = outputInterface ?? throw new ArgumentNullException(nameof(outputInterface));
        }
    }
}
