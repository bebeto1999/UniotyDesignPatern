public class AttackManager
{
    // The first implmentation of this cla violats the OCP. Cuz evrytime I add a nw attack I would change it by addin gnew lines
    // When the project reaches 50+ attack types it looses on readabelity and maintanability witch mean removing a feature of adding feature my break the code base, and the UnitTeste code.
    public float CalculateDamage(Attack attack)  
    {
        return attack.CalculateDamage();
    }
}
