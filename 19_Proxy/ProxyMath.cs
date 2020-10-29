using System;
public class ProxyMath : IMath
{
    private MathService _math;
    public ProxyMath(MathService math)
    {
        _math = math;
    }
    public double Add(double x, double y)
    {
        if (x < 0 || y < 0)
            throw new Exception("Number must be positive.");

        return _math.Add(x,y);
    }

    public double Div(double x, double y)
    {
        if (x < 0 || y < 0)
            throw new Exception("Number must be positive.");

        return _math.Div(x, y);
    }

    public double Mul(double x, double y)
    {
        if (x < 0 || y < 0)
            throw new Exception("Number must be positive.");

        return _math.Mul(x, y);
    }

    public double Sub(double x, double y)
    {
        if (x < 0 || y < 0)
            throw new Exception("Number must be positive.");

        return _math.Sub(x, y);
    }
}
