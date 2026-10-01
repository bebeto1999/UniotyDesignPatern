using Unity.VisualScripting;
using UnityEngine;

public class EnnemySpowner : Factory
{
    [SerializeField] private Ennemy productPrefabe;
    public override IProduct GetProduct(Vector3 position, Quaternion rotation)
    {
        var instance = Instantiate(productPrefabe, position, rotation);
        var newProduct  = instance.GetComponent<IProduct>();

        newProduct.Init();

        return newProduct;
    }
}

public class DialogueLineSpowner : Factory
{
    [SerializeField] private Dialogue dialogue;
    public override IProduct GetProduct(Vector3 position, Quaternion rotation)
    {
        throw new System.NotImplementedException();
    }
}

public class Dialogue : IProduct
{
    public void Init()
    {
        throw new System.NotImplementedException();
    }
}
