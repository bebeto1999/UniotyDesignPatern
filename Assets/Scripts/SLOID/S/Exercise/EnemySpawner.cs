using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public int startEnemyAmount = 5;

    public float spownRange = 10;
    public GameObject enemyPrefab;  // if this wes nnot SRP focused i would have a Factory system;


    /// <summary>
    /// Spown the total enemy of the current wave based on the difficulty favue.
    /// </summary>
    /// <param name="difficulty">a float value from wero to infinity</param>
    /// <returns></returns>
    public List<GameObject> SpownEnemyBasedOnDifficulty(float difficulty) // If there was an enemy 
    {
        if(enemyPrefab == null ) Debug.LogError("Enemy prefabe is not set in enemySpowner");
        
        if(difficulty <= 0 )
            return new List<GameObject>();


        var enemiesToSpown = Mathf.RoundToInt(startEnemyAmount + difficulty);
        var enemies = new List<GameObject>();

        for(int i = 0; i < enemiesToSpown; i++)
        {
            var randomPos = Random.insideUnitSphere * spownRange;
            var enemy = Instantiate(enemyPrefab, randomPos, Quaternion.identity);
            enemies.Add(enemy);
        }
        

        return enemies; 
    }
}
