using System.Collections.Generic;
using UnityEngine;

public class AnalyticsService : MonoBehaviour
{

    public static AnalyticsService Instance {get; private set;}
    public struct WaveAnalytics { public int wave;}
    public struct Session { public float playTime; public List<WaveAnalytics> waveAnalytics;}

    Session session;

    void Awake()
    {
        Instance = this;
        session = new Session();
    }

    public void SaveWaveAnalytics(int currentWave)
    {
        var waveAnalytics = new WaveAnalytics
        {
            wave = currentWave
        };
        session.waveAnalytics.Add(waveAnalytics);
    }

    public void SendSession() // Called when the application is closed;
    {
        session.playTime = Time.time;


        // network stuff 


    }
}
