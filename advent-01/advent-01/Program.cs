namespace advent_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("sample.txt");
            List<string> caloriesList = new List<string>(data);

            int caloriesSum = 0;
            int maxCalories = 0;
            foreach (string calories in caloriesList)
            {
                if (calories == string.Empty)
                {
                    maxCalories = Math.Max(maxCalories, caloriesSum);
                    Console.WriteLine($"Total calories: {caloriesSum}");
                    Console.WriteLine($"Current max val: {maxCalories}");

                    caloriesSum = 0;

                }

                else
                {
                    int caloriesAmount = int.Parse(calories);
                    caloriesSum += caloriesAmount;
                    Console.WriteLine(caloriesAmount);
                }
            }
            maxCalories = Math.Max(maxCalories, caloriesSum);
            Console.WriteLine($"Total calories: {caloriesSum}");
            Console.WriteLine($"Max calories value is {maxCalories}");
        }

    }
}