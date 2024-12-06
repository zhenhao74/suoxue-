using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.learn
{
    public class ForSentence
    {
        public float Jjcc(float a, float b,string c)
        {
            float xxx= 0 ;
           /* if (c == "+")
            {
                xxx = (a + b);
            }
            else if (c == "-")
            {
                xxx = (a - b);
            }
            else if(c == "*")
            {
                xxx = (a*b);
            }
            else if (c == "/")
            {
                xxx = (a/b);
            }*/
            //return (float)xxx;
            switch (c)
            {
                case "+":
                    xxx = a + b;
                break;
                case "-":
                    xxx = a - b;
                break;
                case "*":
                    xxx = a * b;
                break;
                case "/":
                    xxx = a / b;
                break;  
            }
            return xxx;
        }
        public string[] Fcc( float a, float b,string c) 
        {
            string[] fcc = new string[4];
            fcc[0] = a.ToString();
            fcc[1] = b.ToString();
            fcc[2] = c.ToString();
            switch (c)
            {
                case "+":
                    fcc[3] = (a + b).ToString();
                    break;
                case "-":
                    fcc[3] = (a - b).ToString();
                    break;
                case "*":
                    fcc[3] = (a * b).ToString();
                    break;
                case "/":
                    fcc[3] = (a / b).ToString();
                    break;
            }   
            return fcc;
        }
    }
}
