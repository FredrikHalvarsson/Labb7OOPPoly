namespace Labb7OOPPoly
{
    internal class Program
    {
        static void Main()
        {
            //programmet startar i en do while loop
            bool run = true;
            do
            {
                //programmet rensar konsollen och visar en meny
                Console.Clear();
                Console.WriteLine("Calculate Area of:\n" +
                    "1. Rectangle\n" +
                    "2. Square\n" +
                    "3. Circle\n" +
                    "4. Parallelogram\n" +
                    "5. Ellipse\n" +
                    "\nOr input 0 to Exit\n");
                Console.Write("--> ");
                //Användaren matar in ett menyval
                string temp = Console.ReadLine();
                switch (temp)
                    //Switchen körs efter användarens inmatning
                {
                    case "0":
                        //0 avslutar programmet
                        run = false;
                        break;
                    case "1":
                        //varje annan case skapar en instans av respektive klass och kör dess metod i en WriteLine så användaren får se returvärdet
                        Rectangle rectangle = new Rectangle();
                        Console.Clear();
                        Console.WriteLine($"Rectangle Area: {rectangle.Area()}" +
                            $"\nBase: {rectangle.Base}\tHeight: {rectangle.Height}");
                        //Hållkod så att användaren hinner se resultatet innan programmet hoppar tillbaka till menyn
                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Square square = new Square();
                        Console.Clear();
                        Console.WriteLine($"Square Area: {square.Area()}" +
                            $"\nSide: {square.Side}");
                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Circle circle = new Circle();
                        Console.Clear();
                        Console.WriteLine($"Circle Area: {circle.Area()}" +
                            $"\nRadius: {circle.Radius}");
                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        break;
                    case "4":
                        Parallelogram parallelogram = new Parallelogram();
                        Console.Clear();
                        Console.WriteLine($"Parallelogram Area: {parallelogram.Area()}" +
                            $"\nBase: {parallelogram.Base}\tHeight: {parallelogram.Height}");
                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        break;
                    case "5":
                        Ellipse ellipse = new Ellipse();
                        Console.Clear();
                        Console.WriteLine($"Ellipse Area: {ellipse.Area()}" +
                            $"\nRadius A: {ellipse.RadiusA}\tRadius B: {ellipse.RadiusB}");
                        Console.WriteLine("\nPress any key to return to main menu...");
                        Console.ReadKey();
                        break;
                }
            } while (run);
        }
    }
}