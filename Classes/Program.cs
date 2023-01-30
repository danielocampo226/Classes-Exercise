namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Ford = new Car();
            Ford.Make = "Ford";
            Ford.Model = "Focus";
            Ford.Year = 2013;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { Ford, mazda, chevy};

            foreach(Car vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}" );
            }
            
            
           

        }
    }
}
