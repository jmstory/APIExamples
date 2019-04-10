// https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callermembernameattribute?view=netframework-4.7.2

using System;


namespace CallerMemberNameAttributeExample
{  
    class Program
    {       
       static void TraceMessage(string message,
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
        
        static void Main(string[] args)
        {       
            // @전민기: 예제 추가 할 것
            
            TraceMessage("aa");
        }
    }
}
