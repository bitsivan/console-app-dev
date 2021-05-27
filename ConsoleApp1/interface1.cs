using System;

public interface IInterface1
{
    void Show();
}

public class ClassA:IInterface1
{
    public void Show(){
        Console.WriteLine("Welcome to Interface1");
    }
}