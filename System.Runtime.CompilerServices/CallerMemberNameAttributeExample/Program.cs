// https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callermembernameattribute?view=netframework-4.7.2

using System;


namespace CallerMemberNameAttributeExample
{    
   [System.AttributeUsage(System.AttributeTargets.Parameter, Inherited=false)]
  
   public sealed class CallerMemberNameAttribute : Attribute
   {
        public void DoProcessing()
        {
            TraceMessage("Something happened");
        }
        public void TraceMessage(string message,
        [System.Runtime.CompilerServices.CallerFilePath] string memberName = "",
        [System.Runtime.CompilerServices.CallerMemberName] string sourceFilePath ="",
        [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0
        )
        {
            System.Diagnostics.Trace.WriteLine("message: " + message);
            System.Diagnostics.Trace.WriteLine("memberName: " + memberName);
            System.Diagnostics.Trace.WriteLine("sourceFilePath: " + sourceFilePath);
            System.Diagnostics.Trace.WriteLine("sourceLineNumber: " + sourceLineNumber);
        }   
   }
    class Program
    {       
       
        
        static void Main(string[] args)
        {       
            // @전민기: 예제 추가 할 것
            CallerMemberNameAttribute TestCallerMemberNameAttribute = new CallerMemberNameAttribute();
            TestCallerMemberNameAttribute.DoProcessing();
        }
    }
}
