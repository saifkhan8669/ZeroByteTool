using System;
using System.IO;

namespace ZeroByteTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            if (args.Length == 1)
            {
                byte[] infile = File.ReadAllBytes(args[0]);
                
                for (int i = 0; i <= infile.Length; i++)
                {
                    byte[] zbt = new byte[infile.Length];
                    File.WriteAllBytes(args[0], zbt);
                    break;
                }                 
            }

            else
            
            {
                Console.Clear();
                Console.WriteLine(AppDomain.CurrentDomain.FriendlyName + " <input file>");
            }


        }
    }
}
