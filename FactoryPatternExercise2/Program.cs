namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctAnswer;

            do
            {
                correctAnswer = true;

                Console.WriteLine("What Database would you like to use list, sql or mongo?");

                userInput = Console.ReadLine();

                if(userInput != "list" && userInput != "sql" && userInput != "mongo")
                {
                    correctAnswer = false;
                }
            } while (correctAnswer == false);


           var db = DataAccessFactory.GetDataAccess(userInput);

           var products = db.LoadData();
            db.SaveData();

            foreach(var product in products) 
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }

        }
    }
}