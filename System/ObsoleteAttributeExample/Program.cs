using System;
using System.Reflection;

namespace ObsoleteAttributeExample
{
      //이거 왜 오류?
//     [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct |
//     System.AttributeTargets.Enum | System.AttributeTargets.Constructor | 
//     System.AttributeTargets.Method | System.AttributeTargets.Property | 
//     System.AttributeTargets.Field | System.AttributeTargets.Event | 
//     System.AttributeTargets.Interface | System.AttributeTargets.Delegate, Inherited=false)]
//     [System.Runtime.InteropServices.ComVisible(true)]
//     [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Constructor |
//     System.AttributeTargets.Delegate | System.AttributeTargets.Enum | 
//     System.AttributeTargets.Event | System.AttributeTargets.Field | 
//     System.AttributeTargets.Interface | System.AttributeTargets.Method |
//     System.AttributeTargets.Property | System.AttributeTargets.Struct, Inherited=false)]
// [   System.Serializable]
    public sealed class ObsoleteAttribute : Attribute
    {
        

    }
    class Program
    {
        //이것도 왜 오류?
        //[ObsoleteAttribute("This property is obsolete. Use NewProperty instead.", false)] 
        public static string OldProperty
        {
            get {return "The old property value.";}
        }
        public static string CallOldMethod()
        {
            return "You have called CallOldMethod.";
        }
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
