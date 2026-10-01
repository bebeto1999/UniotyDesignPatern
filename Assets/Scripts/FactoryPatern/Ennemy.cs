using System;
using UnityEngine;
public class Ennemy : GameBehaviour, IProduct
{
    public void Init()
    {
        Debug.Log("Enemy Created");
    }
}