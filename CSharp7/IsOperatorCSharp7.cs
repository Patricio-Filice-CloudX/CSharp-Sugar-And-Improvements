using CheatSheet.Extra;

namespace CheatSheet.CSharp7
{
    /// <summary>
    /// A simplified casting an type cheking operator.
    /// For more detail (including casting): https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast
    /// </summary>
    public class IsOperatorCSharp7
    {
        public static void Run()
        {
            object objectPerson = new Person
            {
                Name = "Mark"
            };

            // Old way.
            if (objectPerson.GetType() == typeof(Person))
            {
                Person oldCastedPerson = (Person)objectPerson;
                Console.WriteLine($"Hi I'm the new old version of {oldCastedPerson.Name}");
            }

            if (objectPerson != null && objectPerson is Person)
            {
                Person oldCastedPerson = objectPerson as Person;
                Console.WriteLine($"Hi I'm the new old version of {oldCastedPerson.Name}");
            }

            var castedOldObjectPerson = objectPerson as Person; 
            if (castedOldObjectPerson != null)
            {
                Console.WriteLine($"Hi I'm the new old version of {castedOldObjectPerson.Name}");
            }

            // New way.
            if (objectPerson is Person newCastedPerson)
            {
                Console.WriteLine($"Hi I'm the new casted version of {newCastedPerson.Name}");
            }
        }
    }
}
