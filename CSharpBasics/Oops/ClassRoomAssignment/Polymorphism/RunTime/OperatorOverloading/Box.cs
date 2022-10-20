namespace OperatorOverloading
{
    public class Box
    {
        private double _lenght;
        private double _breath;
        private double _height;

       public Box()
       {

       }

        public Box(double lenght1,double breath1,double height1)
        {
            _lenght=lenght1;
            _breath=breath1;
            _height=height1;
        }

        public double CalculateVolume()
        {
            return _lenght+_breath+_height;
        }

        public static Box operator +(Box box1,Box box2)
        {
            Box box=new Box();
            box._lenght=box1._lenght+box2._lenght;
            box._breath=box1._breath+box1._breath;
            box._height=box1._height+box2._height;
            return box;
        }

        public Box Add(Box box1,Box box2)
        {
            Box box=new Box();
            box._lenght=box1._lenght+box2._lenght;
            box._breath=box1._breath+box1._breath;
            box._height=box1._height+box2._height;
            return box;
        }
    }
}