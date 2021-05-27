using System;

public abstract class G
{
    public abstract void Hello();
    
}

public class G1:G
{
    public override void Hello()
    {
        Console.WriteLine("Hello G1 Test");
    }
}

public class G2:G
{
    public override void Hello()
    {
        Console.WriteLine("Hello G2");
    }
}

