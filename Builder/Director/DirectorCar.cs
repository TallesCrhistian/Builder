using Builder.Interfaces;
using Builder.Product;

namespace Builder.Director
{
    public class DirectorCar
    {
        public Car BuildGol(ICarBuilder carBuilder,string color, string motor, string model, bool hydraulicSteering)
        {
            carBuilder.CreateHidraulicSteering(hydraulicSteering);

            carBuilder.CreateColor(color);

            carBuilder.CreateMotor(motor);

            carBuilder.CreateModel(model);

            return carBuilder.GetCar();
        }
    }
}
