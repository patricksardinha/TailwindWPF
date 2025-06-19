using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailwindWPF.XSD;

namespace TailwindWPF.Tools
{
    /// <summary>
    /// Console app to generate XSD IntelliSense
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TailwindWPF - Generate XSD IntelliSense");
            Console.WriteLine("===========================================");

            try
            {
                var xsdPath = args.Length > 0 ? args[0] : "TailwindWPF.xsd";
                XsdGenerator.GenerateTailwindXsd(xsdPath);

                XsdGenerator.GenerateClassReport("TailwindClasses.txt");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
