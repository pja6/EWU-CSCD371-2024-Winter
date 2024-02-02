using System;


namespace CanHazFunny;

   
    public class Jester(IJokeService jokeService, IJokeServiceOutput outputInterface)
    {
        private readonly IJokeService _jokeService = jokeService ?? throw new ArgumentNullException(nameof(jokeService));
        private readonly IJokeServiceOutput _outputInterface = outputInterface ?? throw new ArgumentNullException(nameof(outputInterface));

        public void TellJoke()
        {
        string theJoke;
        do
            {
                theJoke = jokeService.GetJoke();

            } while (theJoke.Contains("Chuck Norris"));
            
            
            
            outputInterface.Write(theJoke);

            
        }




    }//end of class

 

