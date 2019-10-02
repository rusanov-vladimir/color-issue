using Newtonsoft.Json;
using PG;
using System;
using System.ComponentModel;
using System.Drawing;

namespace ConsoleNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeConverter = TypeDescriptor.GetConverter(typeof(Color));
            var clr = (Color)typeConverter.ConvertFromString("#FFAAEE");
            var toSerialize = new TestClass { Color = clr };
            var str = JsonConvert.SerializeObject(toSerialize);
            var deserialized = JsonConvert.DeserializeObject<TestClass>(str);
            var msg = toSerialize.Color == deserialized.Color ? "Everything works fine! Gratz!" : "Colors are different";
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
