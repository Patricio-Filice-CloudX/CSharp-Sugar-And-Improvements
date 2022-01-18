using CheatSheet.Extra;

namespace CheatSheet.CSharp9
{
    /// <summary>
    /// A less verbiage types referring.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#fit-and-finish-features
    /// </summary>
    public static class TargedTypedCSharp9
    {
        public static void Run()
        {
            //Old way.
            Person oldPerson = new Person();

            (int, int) oldTuple = new(0, 0);

            // New way.
            Person newPerson = new();

            (int, int) newTuple = new();
        }
    }
}
