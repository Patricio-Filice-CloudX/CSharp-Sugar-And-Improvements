using CheatSheet.Extra;

namespace CheatSheet.CSharp8
{
    /// <summary>
    /// A more flexible way to handle alternative flows of execution, this way of coding partially resembles functional programming.
    /// For more detail: https://docs.microsoft.com/en-us/archive/msdn-magazine/2019/may/csharp-8-0-pattern-matching-in-csharp-8-0
    /// </summary>
    public static class PatternMatchingCSharp8
    {
        public static void Run()
        {
            var person = new Person
            {
                Name = "Mark"
            };

            // Old way.
            string oldConsoleValue;
            switch (person.Name)
            {
                case "Mark":
                    oldConsoleValue = "Hi I'm Mark";
                    break;
                case null:
                    throw new ArgumentNullException();
                default:
                    throw new InvalidOperationException();
            }
            Console.WriteLine(oldConsoleValue);

            // New way.
            var newConsoleValue = person.Name switch
            {
                "Mark" => "Hi! I'm Mark",
                null => throw new ArgumentNullException(),
                _ => throw new InvalidOperationException()
            };
            Console.WriteLine(newConsoleValue);

            var extendedNewConsoleValue = person switch
            {
                Person { Name: "Mark" } => "Hi! I'm Mark",
                null => throw new ArgumentNullException(),
                Person personWithNameStartedInM when personWithNameStartedInM.Name.StartsWith('M') => "Hi! My name starts with an M",
                _ => throw new InvalidOperationException()
            };
            Console.WriteLine(extendedNewConsoleValue);
        }
    }
}
