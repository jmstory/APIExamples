// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2

using System;
using System.Collections.Generic;


namespace ListTExample
{
    public class test   
    {
        //public string name{get;set;}
        public string name;
        public int num;
        public override string ToString()
        {
            return "num = " + num + " " + "text = " + name;
        }
        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            test objAsTest = obj as test;
            if(objAsTest == null) return false;
            else return Equals(objAsTest);
        }
        public bool Equals(test other)
        {
            if(other == null) return false;
            return (this.num.Equals(other.num));
        }
       
    }   
    class Program
    {
        static void Main(string[] args)
        {
            List<test> tests = new List<test>();
            // Type List<T> example here.
            tests.Add(new test() {name ="a", num = 0});
            tests.Add(new test() {name ="b", num = 1});
            tests.Add(new test() {name ="c", num = 2});
            tests.Add(new test() {name ="d", num = 3});
            tests.Add(new test() {name ="e", num = 4});
            tests.Add(new test() {name ="f", num = 5});
            
            //1. 출력
            foreach(test aPart in tests)
            {
                Console.WriteLine(aPart);
            }

            //2. 추가
            Console.WriteLine("추가");
            tests.Insert(2,new test() {name ="g" , num = 6});

            foreach(test aPart in tests)
            {
                Console.WriteLine(aPart);
            }

            //3. 삭제1
            Console.WriteLine("삭제1");
            tests.Remove(new test() {name = "g" , num = 6});
            foreach(test aPart in tests)
            {
                Console.WriteLine(aPart);
            }

            //3. 삭제2 
            Console.WriteLine("삭제2");
            tests.RemoveAt(3);
            foreach(test aPart in tests)
            {
                Console.WriteLine(aPart);
            }

            
                    
        }
    }
}
