using Builder.BuildCar;
using Builder.Director;
using Builder.Interfaces;
using Builder.Product;

DirectorCar directorCar = new DirectorCar();
ICarBuilder carBuilder = new Gol();

Car car = directorCar.BuildGol(carBuilder, "Black", "1.6", "G5", true);

Console.WriteLine(car.HydraulicSteering.ToString());
Console.WriteLine(car.Model);
Console.WriteLine(car.Color, car.Motor);
Console.WriteLine(car.Motor);