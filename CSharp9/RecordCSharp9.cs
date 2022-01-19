namespace CheatSheet.CSharp9
{
    /// <summary>
    /// A new way of positional encapsulation of data intended to be non mutable, this way of coding partially resembles functional programming.
    /// For more detail: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#record-types
    /// </summary>
    public static class RecordCSharp9
    {
        public record RecordPersonCSharp9(string Name, int Age);

        public static void Run()
        {
            var recordPerson = new RecordPersonCSharp9("Mark", 2);
            var sameRecordPerson = new RecordPersonCSharp9("Mark", 2);

            //Have value equality.
            Console.WriteLine($"Records are equal: {recordPerson == sameRecordPerson}");

            //Non destrictive mutability through copy.
            var copiedPerson = recordPerson with { Age = 5 };

            //Because records are positional the properties of comparison are implied.
            var switchResult = copiedPerson switch
            {
                ("Mark", > 2) => "I'm the copy of Mark",
                ("Mark", _) => "I'm Mark",
                _ => throw new ArgumentException()
            };

            Console.WriteLine(switchResult);
        }
    }
}
