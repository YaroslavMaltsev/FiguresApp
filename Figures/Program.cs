using Figures.Factory;
using Figures.СustomExceptions;

namespace Figures
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter the name of the figure and its parameters");

                Console.Write("Enter a name for the shape: ");
                string name = Console.ReadLine().ToLower();

                Console.Write("Enter the parameters for the shape (separated by spaces): ");
                string[] parameters = Console.ReadLine().Split(' ');

                int[] sides = new int[parameters.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    sides[i] = int.Parse(parameters[i]);
                }

                var figure = AbstractFigureFactory(name, sides);

                Console.WriteLine(figure.AreaCalculation());
            }
            catch (ExceptionsFigureName e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        protected static AbstractFigureFactory AbstractFigureFactory(string name, params int[] sides) =>
            name switch
            {
                "circle" => new Сircle(sides[0]),
                "triangle" => new Triangle(sides[0], sides[1], sides[2]),
                _ => throw new ExceptionsFigureName("Check the data")
            };
       
    }
}
