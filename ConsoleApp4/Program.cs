namespace Solution
{
    public static class SpacesRemover
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            NoSpace(input);
        }

        public static string NoSpace(string input)
        {
            string result = input.Replace(" ", "");
            return result;
        }
    }
}