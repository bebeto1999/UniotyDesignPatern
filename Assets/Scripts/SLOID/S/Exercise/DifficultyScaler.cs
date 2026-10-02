using UnityEngine;

public class DifficultyScaler : MonoBehaviour
{   
    public readonly float difficultyScaler = .3f;
    private readonly float difficultyMultiplier = 1;
    
    public float GetWaveDifficulty(int wave)
    {
        
        if(wave <= 0)
            return 0;

        var newDifficultyScaler = difficultyScaler * wave;
        var newWaveDifficulty = difficultyMultiplier + newDifficultyScaler;

        return newWaveDifficulty;
    }
}
