// https://docs.microsoft.com/en-us/dotnet/api/system.attribute?view=netframework-4.7.2

using System;
using System.Reflection;

public enum Animal{
    Dog =1,
    Cat, 
    Bird
}
public class AnimalTypeAttribute : Attribute{

    protected Animal thePet;
    public AnimalTypeAttribute(Animal pet)
    {
        thePet = pet;
    }
    public Animal Pet{
        get{ return thePet;}
        set{ thePet = value;}
    }
}

class AnimalTypeTestClass{
    [AnimalType(Animal.Dog)]
    public void DogMethod(){}
    [AnimalType(Animal.Cat)]
    public void CatMethod(){}
     [AnimalType(Animal.Bird)]
    public void BirdMethod(){}
}

namespace AttributeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalTypeTestClass testClass = new AnimalTypeTestClass();
            Type type = testClass.GetType();
            foreach(MethodInfo mInfo in type.GetMethods())
            {
                foreach(Attribute attr in Attribute.GetCustomAttributes(mInfo))
                {
                    if(attr.GetType() == typeof(AnimalTypeAttribute))
                    {
                         Console.WriteLine("Method {0} has a pet {1} attribute.",mInfo.Name, 
                         ((AnimalTypeAttribute)attr).Pet);
                    }
                }
            }
           
            // @전민기: 예제 추가할 것
        }
    }
}
