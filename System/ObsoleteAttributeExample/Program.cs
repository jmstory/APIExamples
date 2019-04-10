using System;
using System.Reflection;

namespace ObsoleteAttributeExample
{  
    class Program
    {
        //경고메세지 터미널에서 확인 가능
        [ObsoleteAttribute("This property is obsolete. Use NewProperty instead.", false)] 
        public static string OldProperty
        {
            get {return "The old property value.";}
        }
        //경고메세지 터미널에서 확인 가능
        [ObsoleteAttribute("This property is obsolete. Use NewProperty instead.", false)] 
        public static string CallOldMethod()
        {
            return "You have called CallOldMethod.";
        }

        //사용불가로 만듬
        //[ObsoleteAttribute("This property is obsolete. Use NewProperty instead.", true)] 
        public static string CallNewMethod() 
        {   
            return "You have called CallNewMethod.";
        }   

        static void Main(string[] args)
        {
            Console.WriteLine(OldProperty);
            Console.WriteLine();
            Console.WriteLine(CallOldMethod());
        }
    }
}
