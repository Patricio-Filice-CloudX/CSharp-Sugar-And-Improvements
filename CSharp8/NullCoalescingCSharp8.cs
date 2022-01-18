using CheatSheet.Extra;

namespace CheatSheet.CSharp8
{
    /// <summary>
    /// Avoids boilerplate assignament when null wants to be avoided.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#null-coalescing-assignment
    /// </summary>
    public static class NullCoalescingCSharp8
    {
        public static void Run()
        {
            // Old way.
            Person oldPerson = null;

            if (oldPerson == null)
            {
                oldPerson = new Person
                {
                    Name = "Mark"
                };
            }

            var unnamedOldPerson = new Person();

            Console.WriteLine("My name is {0}", unnamedOldPerson?.Name == null ? "Person" : unnamedOldPerson.Name);

            var listOfOldNames = new List<string>();
            string oldName = null;
            
            if (oldName != null)
            {
                oldName = "A Name";
            }

            listOfOldNames.Add(oldName);

            // New way.
            Person newPerson = null;

            newPerson ??= new Person { Name = "Mark" };

            var unnamedNewPerson = new Person();

            Console.WriteLine($"My name is {unnamedNewPerson?.Name ?? "Person"}");

            var listOfNewNames = new List<string>();
            string newName = null;

            listOfNewNames.Add(newName ??= "A name");
        }
    }
}
