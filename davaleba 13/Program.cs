namespace davaleba_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          int[] numbers = { 10, 20, 30, 40, 50 };


          CollectionHelper.PrintReverse(numbers);


          Console.WriteLine(CollectionHelper.GetFirstElement(numbers));


          Console.WriteLine(CollectionHelper.GetLastElement(numbers));


          Console.WriteLine(CollectionHelper.ContainsElement(numbers, 30));


          Console.WriteLine(CollectionHelper.CountElements(numbers));


          Console.WriteLine(CollectionHelper.FindIndex(numbers, 40));
            
        }       
    }
}