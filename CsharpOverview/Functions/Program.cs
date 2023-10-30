namespace Functions
{

    public enum Shape
    {
        Triangle,
        Circle,
        Square,
        Rectangle
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            var squareArea = getArea(5, Shape.Square);
            var circleArea = getArea(5, Shape.Circle);
            var triArea = getArea(5, 6, Shape.Triangle);
            var rectArea = getArea(5, 6, Shape.Rectangle);

            var optSquare = getAreaOptionaly(5);
            var optCircle = getAreaOptionaly(5, shape: Shape.Circle);
            var optTriangle = getAreaOptionaly(5, 5, Shape.Triangle);
            var optRectangle = getAreaOptionaly(5, 6, Shape.Rectangle);


        }

        static double getArea(int unitLength, Shape shape)
        {
            //üçgen: 2
            //Circle: 1
            //Square: 1
            //Rectangle: 2
            switch (shape)
            {

                case Shape.Circle:
                    return Math.Pow(unitLength, 2) * Math.PI;
                case Shape.Square:
                    return Math.Pow(unitLength, 2);
                default:
                    throw new Exception("Bu fonksiyon sadece Daire ve Kare içindir");

            }

        }

        static double getArea(int unitLength1, int unitLength2, Shape shape)
        {
            switch (shape)
            {
                case Shape.Triangle:
                    return (unitLength1 * unitLength2) / 2;
                case Shape.Rectangle:
                    return unitLength2 * unitLength1;

                default:
                    throw new Exception("Bu fonksiyon sadece Üçgen ve Dikdörtgen içindir");
            }
        }


        static double getAreaOptionaly(int unitLength1, int unitLength2 = 1, Shape shape = Shape.Square)
        {
            switch (shape)
            {
                case Shape.Triangle:
                    return (unitLength1 * unitLength2) / 2;
                case Shape.Circle:
                    return Math.PI * Math.Pow(unitLength1, 2);

                case Shape.Square:
                    return Math.Pow(unitLength1, 2);
                case Shape.Rectangle:
                    return unitLength1 * unitLength2;
                default:
                    return 0;

            }
        }
    }
}