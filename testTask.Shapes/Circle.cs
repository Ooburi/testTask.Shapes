namespace testTask.Shapes
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double Square => (Math.Pow(_radius, 2d) * Math.PI);
    }
}
