namespace task2;

public class Train : Transport
{
    public Train(string name,string model,string color,int engine)
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
