namespace RequiredMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Firstname = "Dirk",
                Lastname = "Strauss",
                Age = 47
            };

            //person.Firstname = ""; // Error
            //person.Lastname = ""; // Error
            person.Age = 1;                        
        }
    }
}