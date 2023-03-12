public class Math
{
    //attributes
    //constructors
    //methods
    public int Multiply(int number1, int number2)
    {
        int product = number1*number2;
        return product;
    }
    public float Divide(int number1, int number2)
    {
        return number1/number2;
    }

   public int Sum(List<int> numbs)
   {
        int sum = 0;//creating empty variable

        foreach(int num in numbs)
        {
            sum=sum+num;

        }
        return sum;


   }
   

   
}