using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.learn
{
    public class TestLib
    {
        private string className = "Class xx";
        public TestLib()
        {
            className = "Class 43";
            Console.WriteLine("Instancing---");
        }
        ~TestLib() 
        {
            Console.WriteLine("GO");
        }
        public string Run()
        {
            return className;
         }
        //public abstract string Run();
        
    }
    internal class SubTestLib : TestLib
    {
        private string className = "Class xx";
        public SubTestLib()
        {
            className = "Class 44";
            Console.WriteLine("Instancing---2");
        }
        //public override string Run()
        //{
       //     return className;
       // }
    }
}
