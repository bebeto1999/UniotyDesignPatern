using System;
using UnityEngine;

public abstract class Attack : ScriptableObject
{
    public abstract float CalculateDamage();
}

[CreateAssetMenu(fileName = "Attack", menuName = "Attacks/PoisonAttack")]
public class PoisonAttack : Attack
{
   [SerializeField] private float damage;
 
    public override float CalculateDamage()
    {
        return damage;
    }
}