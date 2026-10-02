using TMPro;
using UnityEngine;

public class WaveUI : MonoBehaviour
{
    [SerializeField] WaveData waveData;
    [SerializeField] TextMeshProUGUI waveDisplayer;
    [SerializeField] TextMeshProUGUI enemyDisplayer;
    [SerializeField] TextMeshProUGUI scoreDisplayer;
    [SerializeField] TextMeshProUGUI difficultyDisplayer;

    private void OnWaveEnemyAmountChange()
    {
        if(enemyDisplayer)
            enemyDisplayer.text = $"Enemy Alive : {waveData.currentSpownedEnemy}";
        else
            Debug.LogError("enemyDisplayer (TextMeshProUGI is not set in WaveUI)");
    }

    private void OnWaveProgressChange()
    {
        if(waveDisplayer)
            waveDisplayer.text = $"Current Wave : {waveData.currentWave}";
        else
            Debug.LogError("waveDisplayer (TextMeshProUGI is not set in WaveUI)");
    }

    private void OnScoreChange()
    {
        if(scoreDisplayer)
            scoreDisplayer.text = $"Score : {waveData.currentScore}";
        else
            Debug.LogError("scoreDisplayer (TextMeshProUGI is not set in WaveUI)");
    }

    private void OnWaveDifficultyChange()
    {
        if(difficultyDisplayer)
            difficultyDisplayer.text = $"Current Difficulty : {waveData.currentDifficulty}";
        else
            Debug.LogError("difficultyDisplayer (TextMeshProUGI is not set in WaveUI)");
    }

    
    void OnEnable()
    {
        if(waveData == null ) Debug.LogError("WaveData is not set in WaveUI Class");

        waveData.onWaveDifficultyValueChange += OnWaveDifficultyChange;
        waveData.onCurrentScoreValueChange += OnScoreChange;
        waveData.onCurrentWaveValueChange += OnWaveProgressChange;
        waveData.onCurrentSpownedEnemyValueChange += OnWaveEnemyAmountChange;
    }

    void OnDisable()
    {
        if(waveData == null ) Debug.LogError("WaveData is not set in WaveUI Class");

        waveData.onWaveDifficultyValueChange -= OnWaveDifficultyChange;
        waveData.onCurrentScoreValueChange -= OnScoreChange;
        waveData.onCurrentWaveValueChange -= OnWaveProgressChange;
        waveData.onCurrentSpownedEnemyValueChange -= OnWaveEnemyAmountChange;
    }

}
