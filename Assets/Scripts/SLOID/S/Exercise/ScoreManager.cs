public class ScoreManager // Simple score system. It only give score based on the wave
{
    public float playerScore {get; private set;}
    public readonly float scorePerWaveFinished = 1000f;

    public void SetPlayerScoreBasedOnWave(int currentWave)
    {
        var finishedWave = currentWave - 1;

        if(finishedWave <= 0)
        {
            playerScore = 0;
            return;
        }
        
        var newScore = scorePerWaveFinished * finishedWave;
        playerScore = newScore;
    }
}
