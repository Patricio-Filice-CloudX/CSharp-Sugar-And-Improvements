using CheatSheet.Extra;

namespace CheatSheet.CSharp6
{
    /// <summary>
    /// Simplifying string formatting with in string variable binding
    /// </summary>
    public static class StringInterpolationCSharp6
    {
        public static void Run()
        {
            var person = new Person
            {
                Name = "Mark"
            };

            // Old way.
            Console.WriteLine("Hi! My name is {0}", person.Name);

            // New way.
            Console.WriteLine($"Hi! My name is {person.Name}");
        }
    }
}
