namespace AsyncHello
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var helloWorld = AsyncReadFile.Concat("Hello.txt", "World.txt");
            Console.WriteLine(helloWorld.Result);
        }
    }
}