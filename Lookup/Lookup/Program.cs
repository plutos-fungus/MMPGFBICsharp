using Lookup;
using System;
using System.Collections.Generic;
using System.IO;
namespace lookup
{
    class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            string line;
            string[] pos;
            List<NA> thisNACollection = new List<NA>();

            
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\NA.csv");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    pos = line.Split(",");
                    NA thisNA = new NA(pos[0], pos[1], Convert.ToDouble(pos[2]), Convert.ToDouble(pos[3]), Convert.ToDouble(pos[4]));

                    thisNACollection.Add(thisNA);


                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}