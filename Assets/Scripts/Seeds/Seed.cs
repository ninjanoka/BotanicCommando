using NUnit.Framework;
using System;
using UnityEngine;

public class Seed : MonoBehaviour
{
    [SerializeField] private SeedScriptableObject seed;

    public int waterLevel;
    public int sunLevel;
    public int foodLevel;

    public int reward ()
    {
        return seed.reward;
    }

    public int GetCount()
    {
        return seed.seedStages.Count;
    }

    public void PlacePlantByStage(int stage, Transform parent)
    {
        // -1 because we start at 0

        Instantiate(seed.GetPrefabByStage(stage -1), parent);
    }
}
