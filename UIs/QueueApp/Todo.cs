// See https://aka.ms/new-console-template for more information
public class Todo
{
    public string Describe { get; set; }
    public double Time { get; set; }
    public override string ToString()
    {
        return $"{Describe, -50} {Time, -10}"; 
    }
}

