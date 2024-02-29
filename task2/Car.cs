namespace task2;

public class Car : Transport
{
     public Car(string name,string model,string color,double engine)
    : base(name,model,color,engine)
    {}
    public void Info()
    {
        Print();
    }
    public void GetInfo()
    {
        Console.WriteLine($"{_name} {_model} {_color} {_engine}");
    }
}
