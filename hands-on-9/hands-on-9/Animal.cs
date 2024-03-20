namespace hands_on_9;

public interface IAnimal

{
    public void Speak();
}

public class Dog : IAnimal

{
    public void Speak()
    {
        Console.WriteLine("woof");
    }
}

public class Cat: IAnimal

{
    public void Speak()
    {
        Console.WriteLine("meow");
    }
}

public enum AnimalType
{
    Dog,
    Cat
}

public static class AnimalFactory
{
    public static IAnimal Create(AnimalType animalType)
    {
        switch (animalType)
        {
            case AnimalType.Dog:
                return new Dog();
                break;
            case AnimalType.Cat:
                return new Cat();
                break;
            default:
                throw new Exception("Invalid animal type");
        }
    }
}