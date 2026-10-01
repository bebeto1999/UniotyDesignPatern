using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;


public interface IProduct
{
    public void Init();
}

public abstract class Factory : GameBehaviour
{
    public abstract  IProduct GetProduct(Vector3 position, Quaternion rotation);
}
