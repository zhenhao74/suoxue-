using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.learn
{
    public class CAR
    {
        private string name;
        private string color;
        public string slh()
        {
            return string.Format($"它是{name}{color}色的车");
        }
        public CAR(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
    }
    public class shCAR:CAR
    {
        private string name;
        private string color;
        public shCAR(string name, string color):base(name,color)
        {

            this.name=name;
            this.color = color;

        }
    }
    
}
