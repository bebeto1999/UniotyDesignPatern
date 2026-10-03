

using System;

public interface ITurnable
{
    public void TurnLeft();
    public void TurnRight();
}

public interface IMovable
{
    public void GoForward();
    public void Reverse();
}

public class RoadVehicle : IMovable, ITurnable
{ 
    public float moveSpeed = 3;
    public float turnSpeed = 6;
    public virtual void GoForward()
    {
        throw new NotImplementedException();
    }

    public virtual void Reverse()
    {
        throw new NotImplementedException();
    }

    public virtual void TurnLeft()
    {
        throw new NotImplementedException();
    }

    public virtual void TurnRight()
    {
        throw new NotImplementedException();
    }
}

public class RailVehicle : IMovable
{
    public float moveSpeed = 3;
    public virtual void GoForward()
    {
        throw new NotImplementedException();
    }

    public virtual void Reverse()
    {
        throw new NotImplementedException();
    }
}

public class Car : RoadVehicle
{
    public override void GoForward()
    {
    }

    public override void Reverse()
    {
    }

    public override void TurnLeft()
    {
    }

    public override void TurnRight()
    {
    }
}

public class Train : RailVehicle
{
    public override void GoForward()
    {
    }

    public override void Reverse()
    {
    }
}