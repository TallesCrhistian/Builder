using Builder.Product;

namespace Builder.Interfaces
{
    public interface ICarBuilder
    {
        void CreateModel(string model);

        void CreateColor(string color);

        void CreateMotor(string motor);

        void CreateHidraulicSteering(bool hidraulicSteering);

        Car GetCar();
    }
}
