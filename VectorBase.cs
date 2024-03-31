namespace VectorCalculator
{
    internal class VectorBase
    {
        public int _fields{get; private set;}

        internal void SetFields(int fields)
        {
            _fields = fields;
        }
    }

    internal class Vector2D : VectorBase
    {

        private double _xValue;
        private double _yValue;

        public Vector2D(double xValue, double yValue)
        {
            _xValue = xValue;
            _yValue = yValue;
            SetFields(2);
        }

        public double Magnitude()
        {
            double value = _xValue*_xValue + _yValue*_yValue;
            return Math.Sqrt(value);
        }
    }

    internal class Vector3D : VectorBase
    {
        private double _xValue;
        private double _yValue;
        private double _zValue;

        public Vector3D(double xValue, double yValue, double zValue)
        {
            _xValue = xValue;
            _yValue = yValue;
            _zValue = zValue;
            SetFields(3);
        }

        public double Magnitude()
        {
            double value = _xValue*_xValue + _yValue*_yValue + _zValue*_zValue;
            return Math.Sqrt(value);
        }
    }
}