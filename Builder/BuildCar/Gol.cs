using Builder.Interfaces;
using Builder.Product;

namespace Builder.BuildCar
{
    public class Gol : ICarBuilder
    {
        private Car car = new Car();

        public void CreateColor(string color)
        {
            car.Color = color;
        }

        public void CreateHidraulicSteering( bool hydraulicSteering)
        {
            car.HydraulicSteering = hydraulicSteering;
        }

        public void CreateModel(string model)
        {
            car.Model =  model;
        }

        public void CreateMotor(string motor)
        {
            car.Motor = motor;
        }

        public Car GetCar() => car;
    }
}
