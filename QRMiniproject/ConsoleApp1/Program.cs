using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ class Women
    {
        public string name;
        public int age;
}
    class Program
    {
        static void Main(string[] args)
        {
            Women[] womens ={
                new Women(){ name = "아라", age = 24 },
                new Women(){ name = "민희",age =20},
                new Women(){ name = "현아" , age =22 } 
                
            };
            var Woman = from Women in womens
                        where Women.age > 20
                        orderby Women.age ascending
                        select new { title = "성인여자", name = Women.name };
           
        }
    }
}
