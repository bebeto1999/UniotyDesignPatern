using UnityEngine;
using UnityEngine.UIElements;

public class Exemple : GameBehaviour
{


    
}

public interface IShape
{
    public float GetErea();
}

public class AreaCalculator 
{
    public float GetErea(IShape shape)
    {
        return shape.GetErea();
    }
}
public class Rectangle : IShape
{
    public float width = 4;
    public float height = 2;

    public float GetErea()
    {
        return height * width;
    }
}

public class Circle : IShape
{
    public float radius = 2;

    public float GetErea()
    {
        return Mathf.PI * Mathf.Pow(radius, 2);
    }
}

