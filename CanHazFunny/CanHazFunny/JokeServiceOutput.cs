using System;


namespace CanHazFunny;

    public class JokeServiceOutput : IJokeServiceOutput
    {
        public void Write(string joke)
        {
            Console.WriteLine(joke);
        }
    }

