class Program
{
    static void Main()
    {
        Math math = new Math();//instance (math) can be anything. 
        int result = math.Multiply(6, 3); //result is storing 
        Console.WriteLine(result);

        Console.WriteLine(math.Divide(12,4));

        List<int> numbs = new List<int>(){4, 8, 12, 3};
        Console.WriteLine(math.Sum(numbs));
   }

}
