using System;
using System.Text;
using static System.Console;

namespace ConsoleApp1
    {
    class Program
{
    class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Test(string str)
        {
            WriteLine("Test\n");
            return "return from Test";
        }
    }
    public delegate string GetResult(string arg1);
    static void Main(string[] args)
    {
        Person person;
        person = new Person("Alex");
        GetResult functions = null;

        //functions = (string a) =>
        //{
        //    WriteLine("Лямбда\n");
        //    return "Лямбда";
        //};
        functions += person.Test;
        functions += person.Test;
        functions += person.Test;
        functions += person.Test;
            foreach (var func in functions.GetInvocationList())
            {
            WriteLine((func as GetResult )?.Invoke("Вызов"));
            }
        //    if (functions != null)
        //    {
        //WriteLine(functions("Вызов"));
        //    }
        //    else
        //    {
        //        WriteLine("null");
        //    }
            ReadKey();
    }

}
}

