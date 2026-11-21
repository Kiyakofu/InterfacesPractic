namespace InterfacesPractic
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1, 2, 3");
            int[] numbers = { 7, 2, 9, 4, 1 };
            Array myArray = new Array(numbers);

            myArray.Show();
            myArray.Show("Initial array state");

            Console.WriteLine("Max value: " + myArray.Max());
            Console.WriteLine("Min value: " + myArray.Min());
            Console.WriteLine("Average value: " + myArray.Avg());
            Console.WriteLine("Search 9: " + myArray.Search(9));
            Console.WriteLine("Search 100: " + myArray.Search(100));

            myArray.SortAsc();
            myArray.Show("Sorted Ascending");

            myArray.SortDesc();
            myArray.Show("Sorted Descending");

            myArray.SortByParam(true);
            myArray.Show("Sorted by param (true = Asc)");

            Console.WriteLine("\n4");
            IShape circle = new Circle(5);
            Console.WriteLine("Circle -> Area: " + Math.Round(circle.CalculateArea(), 2) + ", Perimeter: " + Math.Round(circle.CalculatePerimeter(), 2));

            IShape rectangle = new Rectangle(4, 6);
            Console.WriteLine("Rectangle -> Area: " + rectangle.CalculateArea() + ", Perimeter: " + rectangle.CalculatePerimeter());

            IShape triangle = new Triangle(3, 4, 5);
            Console.WriteLine("Triangle -> Area: " + triangle.CalculateArea() + ", Perimeter: " + triangle.CalculatePerimeter());

            Console.WriteLine("\n5");
            IDrivable car = new Car();
            car.StartEngine();
            car.Drive();
            car.StopEngine();

            IDrivable moto = new Motorcycle();
            moto.StartEngine();
            moto.Drive();
            moto.StopEngine();
        }
    }
}
