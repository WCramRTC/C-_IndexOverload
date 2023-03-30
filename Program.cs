namespace C__IndexOverload
{
    internal class Program
    {
        static TeamRoster roster;
        static void Main(string[] args)
        {
            roster = new TeamRoster();
            Preload();

            for (int i = 0; i < roster.Count; i++)
            {
                // Using the indexer to access objects in the list, not the actual list itself
                Console.WriteLine(roster[i]);
            }

            Console.ReadKey();
        }

        static void Preload()
        {
            roster.AddPlayer("Emily", "Thompson");
            roster.AddPlayer("Jacob", "Nguyen");
            roster.AddPlayer("Sofia", "Rodriguez");
            roster.AddPlayer("William", "Lee");
            roster.AddPlayer("Mia", "Patel");
            roster.AddPlayer("Ethan", "Wright");
            roster.AddPlayer("Olivia", "Davis");
            roster.AddPlayer("Benjamin", "Brown");
            roster.AddPlayer("Ava", "Wilson");
            roster.AddPlayer("Michael", "Chen");
        }

    }
}