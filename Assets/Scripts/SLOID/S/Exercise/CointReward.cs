using UnityEngine;

public class CointReward : MonoBehaviour, IReward
{
    readonly int startCointAmount = 200; 
    public void GiveLevelReward(int wave)
    {
        var reward = CalculateCointToGive(wave);

        // stor logic
    }

    int CalculateCointToGive(int wave)
    {
        if(wave <= 0 )
            return 0;

        return startCointAmount * wave;
    }
}
