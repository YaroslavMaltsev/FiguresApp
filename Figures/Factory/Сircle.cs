namespace Figures.Factory
{
    public class Сircle : AbstractFigureFactory
    {
        public Сircle(int radius)
        {
            _radius = radius;
        }

        public int _radius { get; set; }

        public override double AreaCalculation()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
