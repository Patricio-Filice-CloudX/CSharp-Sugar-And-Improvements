using CheatSheet.Extra;

namespace CheatSheet.CSharp7
{
    /// <summary>
    /// A simplified casting an type cheking operator
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

            // New way.
            if (objectPerson is Person newCastedPerson)
            {
                Console.WriteLine($"Hi I'm the new casted version of {newCastedPerson.Name}");
            }
        }
    }
}
