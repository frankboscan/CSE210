public class Circle : Shape{
        private double _radius;

        public void SetRadius(double radius){
                _radius = radius;
        }

        public override float GetArea(){
                return 3.14 * _radius;
        }
}
