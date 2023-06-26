namespace testTask.Shapes
{
    public class Triangle : Shape
    {
        /// <summary>
        /// p - half perimeter
        /// </summary>
        private double _a, _b, _c, _p;
        /// <summary>
        /// a,b,c - triangle`s sides
        /// </summary>
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            _p = (a + b + c) / 2d;
        }
        public override double Square => Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
        public bool isRight()
        {
            double a = _a * _a;
            double b = _b * _b;
            double c = _c * _c;

            return (a + b == c || a + c == b || a + b == c);
        }
    }
}
