namespace MatchStat.Interfaces
{
    public interface IAnimal
    {
        int NumberOfLegs { get; set; }
        string Move();

        string Talk();
    }


    public class Dog : IAnimal
    {
        public int NumberOfLegs { get; set; } = 4;
        public string Move()
        {
            return "Walk";
        }

        public string Talk()
        {
            return "woof woof";
        }
    }

    public class Snake : IAnimal
    {
        public int NumberOfLegs { get; set; } = 0;

        public string Move()
        {
            return "creep";
        }

        public string Talk()
        {
            return "sssssssssssssssssss";
        }
    }

    public class Chicken : IAnimal
    {
        public int NumberOfLegs { get; set; } = 2;

        public string Move()
        {
            return "walk";
        }

        public string Talk()
        {
            return "cokoooook";
        }
    }


    public class program
    {
        public program()
        {
            var dog = new Dog();
            var application = new App(dog);
            application.Move();
            application.Talk();
        }
    }

    public class App
    {
        private IAnimal _animal;
        public App(IAnimal animal)
        {
            _animal = animal;
        }

        public void Move()
        {
            var move = _animal.Move();
            Console.WriteLine(move);
        }

        public void Talk()
        {
            var talk = _animal.Talk();
            Console.WriteLine(talk);
        }
    }




    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }

        public abstract void Sleep();
    }

    public class Patient : Person
    {
        public override void Sleep()
        {

        }
    }

    public class Employee : Person
    {
        public override void Sleep()
        {

        }
    }





}