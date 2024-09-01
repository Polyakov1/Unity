using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Test
{
    internal class Class1 : Class2
    {

    }
    abstract class Class2 : IClass3
    {
       public string Name
       { 
            get;  
       }
        public static Class1 Create() 
        {
 
            return new Class1(); 
        }
    }
    interface IClass3
    {
        string Name { get; }
    }
    public static class Class4 
    {
        static string Name { get; set; }
    }
}
