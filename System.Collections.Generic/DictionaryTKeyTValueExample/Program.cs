// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.7.2

using System;
using System.Collections.Generic;

namespace DictionaryTKeyTValueExample
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            // Type Dictionary<TKey, TValue> example here.
            Dictionary<string ,string> openWith = new Dictionary<string,string>();
            openWith.Add("txt","notepad.exe");
            openWith.Add("bmp","paint.exe");
            openWith.Add("dib","paint.exe");
            openWith.Add("rtf","wordpad.exe");

            //1. 예외처리 Key가 없다면 추가
            try
            {
                openWith.Add("txt","winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            //2.Key로 접근
            Console.WriteLine("For key = \"rtf\", value = {0}.",openWith["rtf"]);
           
            //3.Key로 접근하여 value 변경
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.",openWith["rtf"]);

            //4.Key가 존재하지 않을때 , Key/Value 추가
            openWith["doc"] = "winword.exe";

            //5. 예외처리 Key가 존재하지않는다면
            try
            {
                Console.WriteLine("key = \"tif\", value = {0}.",openWith["tif"]);
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("key = \"tif\" is not found");
            }

            //6.
            string value = "";
            if(openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

            //7.ContainsKey Key추가 전 테스트 
            if(!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht","hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
            }

            //8.
            foreach(KeyValuePair<string,string> kvp in openWith)
            {
                Console.WriteLine("Key = {0} , Value = {1}",kvp.Key,kvp.Value);
            }

            //9.value만 얻어올때
            Dictionary<string,string>.ValueCollection valueColl = openWith.Values;

            //10.value 출력
            foreach( string s in valueColl)
            {
                Console.WriteLine("Value = {0}",s);
            }

            //11.Key만 얻어올때
            Dictionary<string,string>.KeyCollection KeyColl = openWith.Keys;

            //12. Key 출력
            foreach( string s in KeyColl)
            {
                Console.WriteLine("Key = {0}",s);
            }

            //13. key/value 제거
            openWith.Remove("doc");
            if(!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }

        }
    }
}
