using System.Collections.Generic;
using System.Linq;
using Codice.Client.BaseCommands;
using UnityEngine;

public interface IReward
{
    public void GiveLevelReward(int wave);
}
public class RewardSystem : MonoBehaviour
{
    [SerializeField] List<IReward> rewards = new(); // to set in the editor

    public void GiveRandomReward(int wave)
    {
        var random = Random.Range(0, rewards.Count -1);
        var reward = rewards[random];

        reward.GiveLevelReward(wave);
    }
}
