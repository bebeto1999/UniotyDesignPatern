using System;
using UnityEngine;
[CreateAssetMenu(fileName = "WaveData", menuName = "Scriptable Objects/WaveData")]
public class WaveData : ScriptableObject
{
    public event Action onCurrentWaveValueChange;
    public event Action onCurrentScoreValueChange;
    public event Action onCurrentSpownedEnemyValueChange;
    public event Action onWaveDifficultyValueChange;
    [field: SerializeField] public int currentWave {get; private set;}
    [field: SerializeField] public float currentScore {get; private set;}
    [field: SerializeField] public int currentSpownedEnemy {get; private set;}
    [field: SerializeField] public float currentDifficulty {get; private set;}

    public void UpdateCurrentWave(int currentWave)
    {
        this.currentWave = currentWave;
        onCurrentWaveValueChange?.Invoke();
    }
    public void UpdateCurrentScore(float currentScore)
    {
        this.currentScore = currentScore;
        onCurrentScoreValueChange?.Invoke();
    }
    public void UpdateCurrentSpownedEnemy(int currentSpownedEnemy)
    {
        this.currentSpownedEnemy = currentSpownedEnemy;
        onCurrentSpownedEnemyValueChange?.Invoke();
    }
    public void UpdateCurrentDifficulty(float currentDifficulty)
    {
        this.currentDifficulty = currentDifficulty;
        onWaveDifficultyValueChange?.Invoke();
    }

}
