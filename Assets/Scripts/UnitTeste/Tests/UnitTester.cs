using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class UnitTester
{
    [Test]
    public void ShapeArea()
    {
        AreaCalculator areaCalculator = new();

        var rectangle = new Rectangle();
        var circle = new Circle();


        Assert.AreEqual(8 , areaCalculator.GetErea(rectangle));
        Assert.AreEqual(13 , Mathf.RoundToInt(areaCalculator.GetErea(circle)));

    }

    // [UnityTest]
    // public IEnumerator WaveController_Advances_When_Enemies_Are_Dead()
    // {
    //     var go = new GameObject("WaveController");
    //     var controller = go.AddComponent<WaveCotroller>();

    //     Assert.AreEqual(2, controller.currentWave);
    //     yield return null;

    // }

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
