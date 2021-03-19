using System;

namespace ClassroomExercise2
{
   
    public abstract class Polygon {
        public abstract bool isLegal();
        public abstract void Display();
        public abstract int getArea();
    }
    public class Rectagnle : Polygon
    {
        private int length,width;

       
        public Rectagnle(int length, int width) {
            this.length = length;
            this.width = width;
            this.Display();
        }

        public int Width { get; set; }
        public int Length { get => length; set => length = value; }

        public override void Display()
        {
            
            if(isLegal())
                Console.WriteLine("You have successfully bulit a rectangle and its area is "+this.getArea());
        }

        public override int getArea()
        {
           ;
            return width * length;
        }

        public override bool isLegal()
        {
         
            return this.length != this.Width;
        }

     
    }
    public class Square : Polygon
    {
        private int length;
        private int width;
        public Square(int length, int width)
        {
            this.length = length;
            this.width = width;
            this.Display();
        }

        public int Width { get => width; set => width = value; }
        public int Length { get => length; set => length = value; }

        public override void Display()
        {
           
            if(isLegal())
                Console.WriteLine("You have successfully bulit a square,and its area is "+this.getArea());
        }

        public override int getArea()
        {
            
            return length * width;
        }

        public override bool isLegal()
        {
            return this.length == this.width;
        }

    }
    public class Triangle : Polygon
    {
        private int firstSide, secondSide, thirdSide;
        public Triangle(int firstSide, int secondSide, int thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            this.Display();
        }

        public int FirstSide { get => firstSide; set => firstSide = value; }
        public int SecondSide { get => secondSide; set => secondSide = value; }
        public int ThirdSide { get => thirdSide; set => thirdSide = value; }

        public override void Display()
        {
            throw new NotImplementedException();
            if(isLegal()) Console.WriteLine("You have successfully bulit a rectangle");
        }

        public override int getArea()
        {
            throw new NotImplementedException();
        }

        public override bool isLegal()
        {
            throw new NotImplementedException();
            if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide
                && secondSide + thirdSide > firstSide)
            {
                return true;
            }
            else
                return false;
        }

    }
    public class ShapeFactory {
        public Polygon getPolygon(String shapeType) {
            if (shapeType == null) {
                return null;
            }
            if (shapeType.Equals("rectangle")) {
                return new Rectagnle(5, 4);
            };
            if (shapeType.Equals("square")) {
                return new Square(4, 4);
            }
            if (shapeType.Equals("triangle")) {
                return new Triangle(3, 4, 5);
            }
            return null;
            
        }
    }
    public class FactoryPatternDemo {
        public static void Main(String[] args){
            ShapeFactory shapefactory = new ShapeFactory();
            Polygon p1 = shapefactory.getPolygon("rectangle");
            Polygon p2 = shapefactory.getPolygon("square");
        }
    }
}