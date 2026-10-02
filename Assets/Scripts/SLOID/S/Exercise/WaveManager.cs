using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;

public class WaveManager : MonoBehaviour
{
    public Text waveText;
    public Text scoreText;
    public AudioSource audioSource;
    public AudioClip nextWaveClip;

    public GameObject enemyPrefab;

    private int currentWave = 1;
    private int score = 0;

    private float difficultyMultiplier = 1f;

    private List<GameObject> aliveEnemies = new();

    void Start()
    {
        LoadProgress();
        StartWave();
    }

    void Update()
    {
        waveText.text = "Wave: " + currentWave;
        scoreText.text = "Score: " + score;

        if(aliveEnemies.Count == 0)
        {
            CompleteWave();
        }
    }

    void StartWave()
    {
        int enemyCount = Mathf.RoundToInt(5 * difficultyMultiplier);

        for(int i = 0; i < enemyCount; i++)
        {
            GameObject enemy =
                Instantiate(enemyPrefab);

            enemy.transform.position =
                Random.insideUnitSphere * 10;

            aliveEnemies.Add(enemy);
        }

        Debug.Log("Spawned " + enemyCount);
    }

    void CompleteWave()
    {
        PlayWaveCompleteSound();

        score += currentWave * 100;

        SaveProgress();

        SendAnalytics();

        GiveReward();

        currentWave++;

        difficultyMultiplier += 0.2f;

        StartWave();
    }

    void PlayWaveCompleteSound()
    {
        audioSource.PlayOneShot(nextWaveClip);
    }

    void SaveProgress()
    {
        File.WriteAllText(
            "save.txt",
            currentWave.ToString());
    }

    void LoadProgress()
    {
        if(File.Exists("save.txt"))
        {
            currentWave =
                int.Parse(
                    File.ReadAllText("save.txt"));
        }
    }

    void SendAnalytics()
    {
        Debug.Log(
            $"Analytics: Wave {currentWave}");
    }

    void GiveReward()
    {
        Debug.Log(
            "Reward granted");
    }
}