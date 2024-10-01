using Lab4_2;

Car car1 = new Car("BMW", 2005, 250);
Car car2 = new Car("Zhiguli", 2000, 180);
Car car3 = new Car("Mercedes", 2020, 320);

Car[] cars = new Car[] { car1, car2, car3 };

Array.Sort(cars, new CarComparer("ProductionYear").Compare);

foreach(Car i in cars)
{
    i.print_all();
}

CarCatalog catalog1 = new CarCatalog(cars);

foreach (Car i in catalog1.GetEnumeratorReverse())
{
    i.print_all();
}

foreach (Car i in catalog1.FilterByMaxSpeed(200))
{
    i.print_all();
}
