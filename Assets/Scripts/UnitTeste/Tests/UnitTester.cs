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

        Assert.AreEqual(2, controller.currentWave);
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
