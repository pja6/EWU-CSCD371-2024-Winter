using System;
using System.IO;

namespace DefaultNamespace
{
    public class FileLogger: BaseLogger
    {
        /*
         * Use the nameof() operator when identifying the class name to the logger ❌✔
           Create a FileLogger that derives from BaseLogger. It should take in a path to a file to write 
           the log message to. When its Log method is called, it should append messages on their own line 
           in the file. The output should include all of the following:
           The current date/time ❌✔
           The name of the class that created the logger ❌✔
           The log level ❌✔
           The message ❌✔
           The format may vary, but an example might look like this "10/7/2019 12:38:59 AM FileLoggerTests 
           Warning: Test message"
         */

        public void Log()
        {
            return null;
            //using (System.IO.Streamwriter )
        }
        
    }
}