using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.learn
{
    public class CAR    //父类
    {
        private string name;    //私有
        private string color;
        public virtual string slh()   
        {
            return string.Format($"它是{name}{color}色的车");
        }
        public CAR(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
    }
    public class shCAR:CAR   //子类
    {
        private string name;
        private string color;
        
        public shCAR(string name, string color):base(name,color)
        {

            this.name=name;
            this.color = color;

        }
        public override string slh()
        {
            return string.Format($"他是{name}牌子的");
        }
        
    }
    public class sssCAR : shCAR  //子类的子类
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
