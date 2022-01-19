using CheatSheet.Extra;

namespace CheatSheet.CSharp6
{
    /// <summary>
    /// A way to bind compile check with code definitions.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof
    /// </summary>
    public static class NameOfCSharp6
    {
        public static void Run()
        {
            var person = new Person
            {
                Name = "Mark"
            };

            var personName = person.Name;

            // Old way for a property (using class Person).
            Console.WriteLine("Name");

            // Old way for a variable.
            Console.WriteLine("personName");


            // New way for a property (using class Person).
            Console.WriteLine(nameof(person.Name));

            // New way for a variable.
            Console.WriteLine(nameof(personName));
        }
    }
}
