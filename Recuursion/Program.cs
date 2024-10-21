namespace Recuursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we call the static method from the static class 
         //var result =   CalcFactorial.CalculateFactorial(4);
         //   Console.WriteLine(result);
         foreach(var die in Directory.GetFiles(@"H:\upwork\Honey"))
            {
                Console.WriteLine(die ,new FileInfo(die).Name);
            }
          
            

        }
    }
}
