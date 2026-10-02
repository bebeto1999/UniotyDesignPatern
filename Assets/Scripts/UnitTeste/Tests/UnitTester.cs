using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class UnitTester
{
    // A Test behaves as an ordinary method
    // [Test]
    // public void UnitTesterSimplePasses()
    // {
    //     ScoreManager scoreManager = new();
    //     scoreManager.SetPlayerScoreBasedOnWave(0);
    //     Assert.AreEqual(scoreManager.playerScore, 0);
    // }

    [UnityTest]
    public IEnumerator WaveController_Advances_When_Enemies_Are_Dead()
    {
        var go = new GameObject("WaveController");
        var controller = go.AddComponent<WaveCotroller>();
        var e = new GameObject("EnemySpowner");
        var eC = go.AddComponent<EnemySpawner>();
        var d = new GameObject("DifficultyScaler");
        var en = new GameObject("Enemy");
        eC.enemyPrefab = en;
        var dC = go.AddComponent<DifficultyScaler>();
        var s = new ScoreManager();
        //controller.Set(s, dC, eC);


        // set up test data
        controller.currentWave = 0;

        yield return null;

        // assert behavior
        Assert.AreEqual(1, controller.currentWave);

        controller.StartNewWave();
        yield return null;

        Assert.AreEqual(1, Mathf.RoundToInt(dC.GetWaveDifficulty(controller.currentWave)));

        Assert.AreEqual(6, controller.currentSpownedEnemy.Count);
        yield return null;

        controller.currentSpownedEnemy.Clear();

        controller.UpdateWave();
        yield return null;

        //Assert.AreEqual(1000, controller.scoreManager.playerScore);
        yield return null;

        Assert.AreEqual(2, controller.currentWave);
        yield return null;

        Assert.AreEqual(2, Mathf.RoundToInt(dC.GetWaveDifficulty(controller.currentWave)));
        yield return null;

        Assert.AreEqual(7, controller.currentSpownedEnemy.Count);
        yield return null;
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    // [UnityTest]
    // public IEnumerator UnitTesterWithEnumeratorPasses()
    // {
    //     // Use the Assert class to test conditions.
    //     // Use yield to skip a frame.
    //     yield return null;
    // }
}
