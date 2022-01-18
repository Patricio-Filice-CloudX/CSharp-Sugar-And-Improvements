namespace CheatSheet.CSharp7
{
    /// <summary>
    /// Allowed variable definition on out parameters.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
    /// </summary>
    public static class OutVariableCSharp7
    {
        public static void Run()
        {
            var stringifiedNumber = "2";

            // Old Way.
            int oldNumber;
            var oldParseResult = int.TryParse(stringifiedNumber, out oldNumber);
            Console.WriteLine($"Success: {oldParseResult} - Number {oldNumber}");

            // New Way.
            var newParseResult = int.TryParse(stringifiedNumber, out int newNumber);
            Console.WriteLine($"Success: {newParseResult} - Number {newNumber}");
        }
    }
}
