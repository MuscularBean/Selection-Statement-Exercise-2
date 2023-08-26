namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {

                case "math":
                    Console.WriteLine("You must be smart.");
                    break;

                case "english":
                    Console.WriteLine("You like to write essays?");
                    break;

                case "science":
                    Console.WriteLine("The mitochindria is the powerhouse of the cell.");
                    break;
                case "art":
                    Console.WriteLine("Ceramics was fun. You ever take that class?");
                    break;
                case "music":
                    Console.WriteLine("You were forced the play the recorder at some point right?");
                    break;
                default:
                    Console.WriteLine("I have never heard of that...");
                    break;

            }
            



        }
    }
}