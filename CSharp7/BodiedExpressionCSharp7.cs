namespace CheatSheet.CSharp7
{
    /// <summary>
    /// Expanded Bodied expressions to constructors and destructors.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
    /// </summary>
    public static class BodiedExpressionCSharp7
    {
        public class OldVersion
        {
            public OldVersion(string name)
            {
                this.Name = name;
            }

            public string? Name { get; set; } 
        
            ~OldVersion()
            {
                this.Name = null;
            }
        }

        public class NewVersion
        {
            public NewVersion(string name) => this.Name = name;

            public string? Name { get; set; }

            ~NewVersion() => this.Name = null;
        }

        public static void Run()
        {
            Console.WriteLine("New Bodied Expressions");
        }
    }
}
