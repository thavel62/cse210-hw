using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    // virtual method
    // public virtual double GetArea()
    // {
    //     Return 0;
    // }
    public abstract double GetArea();
}