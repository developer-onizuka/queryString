using System;

public class MainClass
{
    public static void Main()
    {
        QueryString q = new QueryString();
        q.printString("https://www.example.com/?val1=11111&val2=22222&val3=33333");
    }
}
