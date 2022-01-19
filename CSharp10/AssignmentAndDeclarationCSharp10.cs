namespace CheatSheet.CSharp10
{
    /// <summary>
    /// Is possible to declare and assign multiple variable in the same line.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#assignment-and-declaration-in-same-deconstruction
    /// </summary>
    public static class AssignmentAndDeclarationCSharp10
    {
        public static void Run()
        {
            (int, int) tuple = new();

            // Old way.
            int oldVariable1;
            int oldVariable2;
            (oldVariable1, oldVariable2) = tuple;

            // New way.
            int newVariable1;
            (newVariable1, int newVariable2) = tuple;
        }
    }
}
