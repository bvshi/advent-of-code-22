namespace advent_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("sample.txt");
            List<string> inputList = new List<string>(input);

            Dictionary<string, int> points = new Dictionary<string, int>()
            {
                {"X", 1 },
                {"Y", 2 },
                {"Z", 3 },
            };
            int score = 0;

            foreach (string line in inputList)
            {
                string[] choices = line.Split(" ");

                var computerChoice = choices[0];
                var playerChoice = choices[1];

                if (computerChoice == "A" && playerChoice == "Y" ||
                       computerChoice == "B" && playerChoice == "Z" ||
                       computerChoice == "C" && playerChoice == "X")
                {
                    score += 6 + points[playerChoice];
                }

                else if (computerChoice == "A" && playerChoice == "Z" ||
                       computerChoice == "B" && playerChoice == "X" ||
                       computerChoice == "C" && playerChoice == "Y")
                {
                    score += points[playerChoice];
                }

                else if (computerChoice == "A" && playerChoice == "X" ||
                        computerChoice == "B" && playerChoice == "Y" ||
                        computerChoice == "C" && playerChoice == "Z")  
                {
                    score += 3 + points[playerChoice];
                }

            }

            Console.WriteLine($"Final score is {score}");

        }
    }
}
