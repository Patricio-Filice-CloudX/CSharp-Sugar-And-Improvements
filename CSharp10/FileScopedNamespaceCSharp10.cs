/// <summary>
/// Allows to reduce the space consumed vertically and horizontally by the namespace declaration, the drawback is losing the nesting capability
/// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace
/// </summary>
namespace CheatSheet.CSharp10;
public static class FileScopedNamespaceCSharp10
{
    public static void Run()
    {
        Console.WriteLine("File Scoped Namespace");
    }
}
