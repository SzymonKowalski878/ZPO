using CarSpeed;

List<ICarSpeed> cars = new List<ICarSpeed>();
cars.Add(new Maluch());
cars.Add(new Porshe());
cars.Add(new Ford());

foreach (var car in cars)
{
    Console.WriteLine(car.GetMaxSpeed());
}
