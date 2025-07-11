using System.Globalization;
using System.Text;
using System.Text.Unicode;

namespace CSharp11Features
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UTF-8 Literals
            // UTF-8 Literals
            ReadOnlySpan<byte> utf16 = Encoding.Unicode.GetBytes("AUTH ");
            ReadOnlySpan<byte> utf8 = "AUTH "u8;
            #endregion

            #region Raw string literals
            // Raw string literals
            //var xmlPrologue = "<?xml version="1.0" encoding="UTF-8"?>";
            //var xmlPrologue = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            //var xmlPrologue = @"<?xml version=""1.0"" encoding=""UTF-8""?>";
            //var xmlPrologue = """<?xml version="1.0" encoding="UTF - 8"?>""";
            //var myString = """"This is a """ string with three double quotes"""";

            //var foxColor = "brown";
            //var myString = $"""The quick {foxColor} fox""";

            // When working with JSON => { "course": ".NET 7 and C# 11 Succinctly" }
            //var jsonString = "{\n    \"course\": \".NET 7 and C# 11 Succinctly\"\n}";

            //var jsonString = """
            //{
            //    "course": ".NET 7 and C# 11 Succinctly"
            //}
            //""";

            //var courseName = ".NET 7 and C# 11 Succinctly";
            //var jsonString = $$"""
            //{
            //    "course": "{{courseName}}"
            //}
            //"""; 
            #endregion

            #region List Patterns

            //int[] nums = { 1, 2, 3 };

            ////Console.WriteLine(nums is [1, 2, 3]); // true
            ////Console.WriteLine(nums is [1, 7, 3]); // false
            ////Console.WriteLine(nums is [1, 2, 3, 4]); // false
            ////Console.WriteLine(nums is [0 or 5]); // false


            //var empty = Array.Empty<string>();
            //// outputMatch1 will output "The array is empty"                                               
            //var outputMatch1 = empty switch
            //{
            //    [] => "The array is empty",
            //    [var fullCourse] => $"The course is {fullCourse}",
            //    [var netFx, var lang] => $"This is {lang} on {netFx}",
            //    _ => "No patterns matched"
            //};

            //var course = new[] { ".NET 7 and C# 11 Succinctly" };
            //// outputMatch2 will output "The course is .NET 7 and C# 11 Succinctly"
            //var outputMatch2 = course switch
            //{
            //    [] => "The array is empty",
            //    [var fullCourse] => $"The course is {fullCourse}",
            //    [var netFx, var lang] => $"This is {lang} on {netFx}",
            //    _ => "No patterns matched"
            //};

            //var dotNetAndCSharp = new[] { ".NET 7", "C# 11" };
            //// outputMatch3 will output "This is C# 11 on .NET 7"
            //var outputMatch3 = dotNetAndCSharp switch
            //{
            //    [] => "The array is empty",
            //    [var fullCourse] => $"The course is {fullCourse}",
            //    [var netFx, var lang] => $"This is {lang} on {netFx}",
            //    _ => "No patterns matched"
            //};

            //Console.WriteLine(outputMatch1);
            //Console.WriteLine(outputMatch2);
            //Console.WriteLine(outputMatch3);

            //Console.ReadLine();

            #endregion

            #region Pattern Matching on Spans
            //// Pattern Matching on Spans
            //ReadOnlySpan<char> value = ".NET 7 and C# 11 Succinctly";

            //if (value is ['.', ..])
            //{
            //    Console.WriteLine("The string starts with a dot");
            //} 
            #endregion

        }
    }




}