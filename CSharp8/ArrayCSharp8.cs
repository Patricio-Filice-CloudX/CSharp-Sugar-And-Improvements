namespace CheatSheet.CSharp8
{
    /// <summary>
    /// A non verbiage version to access an array by indexes or ranges.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges
    /// </summary>
    public static class ArrayCSharp8
    {
        public static void Run()
        {
            var names = new string[]
            {
                "James",
                "Joy",
                "John",
                "Rose",
                "Mark"
            };

            //Old way
            var lastOldName = names[names.Length - 1];
            Console.WriteLine(lastOldName);

            var penultimateOldName = names[names.Length - 2];
            Console.WriteLine(penultimateOldName);

            var middleOldNames = names.Skip(1)
                                      .Take(3);

            foreach (var name in middleOldNames)
            {
                Console.WriteLine(name);
            }


            //New Way
            var lastNewName = names[^1];
            Console.WriteLine(lastNewName);

            var penultimateNewName = names[^2];
            Console.WriteLine(penultimateNewName);

            var middleNewNames = names[1..4];

            foreach (var name in middleNewNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
