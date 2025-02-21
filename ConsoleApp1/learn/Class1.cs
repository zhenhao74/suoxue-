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
        private string name;    //私有
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
        public override string slh()
        {
            return string.Format($"他是{}牌子的");
        }
        public shCAR(string name, string color):base(name,color)
        {

            this.name=name;
            this.color = color;

        }

    }
    public class sssCAR : shCAR
    {
        private string name;
        private string color;
        public sssCAR(string name, string color):base (name,color)
        {
            this.name = name;
            this.color = color;
        }
    }
    
}
