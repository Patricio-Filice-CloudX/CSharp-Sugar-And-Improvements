namespace CheatSheet.CSharp7
{
    /// <summary>
    /// Allows to define a method inside another method
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions
    /// </summary>
    public static class LocalFunctionCSharp7
    {
        public static void Run()
        {
            // Old way.
            LocalFunctionCSharp7.OldInnerRun();

            // New way.
            static void NewInnerRun()
            {
                Console.WriteLine("New Inner Run");
            }
            NewInnerRun();
        }

        private static void OldInnerRun()
        {
            Console.WriteLine("Old Inner Run");
        }
    }
}
