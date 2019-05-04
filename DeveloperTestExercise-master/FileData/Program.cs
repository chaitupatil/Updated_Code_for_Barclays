using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            if(args.Length > 0 && args.Length == 2)
            {
                FileUtilities fileUtilities = new FileUtilities();

                Console.WriteLine(fileUtilities.ProcessCommand(args[1], args[0]));
            }
            else
            {
                Console.WriteLine("Invalid number of arguments");
            }
            
        }

    }
}
