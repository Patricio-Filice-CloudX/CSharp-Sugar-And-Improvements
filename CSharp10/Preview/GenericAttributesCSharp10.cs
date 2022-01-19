namespace CheatSheet.CSharp10.Preview
{
    /// <summary>
    /// You can apply generics to an attribute.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#generic-attributes
    /// </summary>
    public static class GenericAttributesCSharp10
    {
        public class OldGenericAttribute : Attribute
        {
            public OldGenericAttribute(Type? type)
            {
                Type = type;
            }

            public Type? Type { get; }

            public object? Value { get; set; }
        }

        public class NewGenericAttribute<T> : Attribute
        {
            public NewGenericAttribute()
            {
                this.Type = typeof(T);
            }

            public Type Type { get; }

            public T? Value { get; set; }
        }

        public static void Run()
        {
            Console.WriteLine("Generic Attribute");
        }
    }
}
