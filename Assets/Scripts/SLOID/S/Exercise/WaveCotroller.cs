using UnityEngine;
using System.Collections.Generic;
using JetBrains.Annotations;

public class WaveCotroller : MonoBehaviour
{

    [SerializeField] EnemySpawner enemySpawner;
    [SerializeField] DifficultyScaler difficultyScaler;
    [SerializeField] SaveSystem saveSystem;
    [SerializeField] WaveData waveData;
    [SerializeField] AudioManager audioManager;
    [SerializeField] RewardSystem rewardSystem;
    ScoreManager scoreManager;

    private int _currentWave;
    public int currentWave  {
        get => _currentWave;
        set
        {
            if(value <= 0)
                value = 1;

            _currentWave = value;
        }
    }


    void Awake()
    {
        scoreManager = new();
        Debug.Assert(saveSystem != null);
        Debug.Assert(enemySpawner != null);
        Debug.Assert(difficultyScaler != null);
    }

    void Start() // In the future this will be a StartWave method to call in order to start the wave
    {
        if(saveSystem == null) Debug.LogError("SaveSystem is not set in the WaveController");
        
        currentWave = saveSystem.GetWave();

        scoreManager.SetPlayerScoreBasedOnWave(currentWave);

        if(waveData == null) Debug.LogError("WaveData is not set in the WaveController");

        waveData.UpdateCurrentScore(currentWave);

        StartNewWave();
    }

    void Update()
    {
        UpdateWave();
    }

    public void StartNewWave()
    {
        if(difficultyScaler != null && enemySpawner != null)
        {
            var currentDifficulty = difficultyScaler.GetWaveDifficulty(currentWave);
            enemySpawner.SpownEnemyBasedOnDifficulty(currentDifficulty);

            // Update the data 
            if(waveData == null) Debug.LogError("WaveData is not set in the WaveController");

            waveData.UpdateCurrentWave(currentWave);
            waveData.UpdateCurrentDifficulty(currentDifficulty);


        }
        else
            Debug.LogError("difficultyScaler or enemySpowner is not set " );
    }

    public void UpdateWave() // the definition is just a placeholder
    {
        if(enemySpawner.AliveEnemyCount() <= 0)
            CompletWave();
    }

    public  void CompletWave()
    {
        AnalyticsService.Instance.SaveWaveAnalytics(currentWave);

        if(rewardSystem == null) Debug.LogError("RewardSystem is not set in WaveController");

        rewardSystem.GiveRandomReward(currentWave);

        if(audioManager == null) Debug.LogError("AudioManager is not set in WaveController");

        audioManager.PlayEndWaveSound();

        currentWave++;

        if(saveSystem == null) Debug.LogError("SaveSystem is not set in the WaveController");

        saveSystem.SaveCurrentWave(currentWave);

        scoreManager.SetPlayerScoreBasedOnWave(currentWave);
        StartNewWave();

        if(waveData == null) Debug.LogError("WaveData is not set in the WaveController");

        waveData.UpdateCurrentScore(scoreManager.playerScore);
    }
}
