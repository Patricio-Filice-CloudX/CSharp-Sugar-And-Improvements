using CheatSheet.Extra;

namespace CheatSheet.CSharp6
{
    /// <summary>
    /// A form to avoid boilerplate null checking
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
    /// </summary>
    public static class NullSpredCSharp6
    {
        public static void Run()
        {
            Person? person = null;

            // Old way.
            if (person == null || person.Name == null)
            {
                Console.WriteLine("Old null check");
            }

            // New Way
            if (person?.Name == null)
            {
                Console.WriteLine("New null check");
            }
        }
    }
}
