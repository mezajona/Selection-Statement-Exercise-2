namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I do not prefer math");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "pe":
                case "p.e.":
                case "physical education":
                    Console.WriteLine("P.E. is fun");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite too!");
                    break;
                case "geography":
                    Console.WriteLine("I like to study that as well");
                    break;
                default:
                    Console.WriteLine("I like that too");
                    break;
            }
        }
    }
}