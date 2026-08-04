namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public interface IWorkable { void Work(); }
            public class Employee : IWorkable
            {
                public void Work() => Console.WriteLine("Working...");
            }

            // Пример использования:
            Employee worker = new Employee();
            IWorkable contract = worker; // Неявное приведение к интерфейсу
            object rawObject = worker;   // Неявное приведение к базовому типу object

        }
    }
}
