using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SeedScriptableObj", menuName = "Scriptable Objects/Seed")]
public class SeedScriptableObject : ScriptableObject
{
    public string seedName;
    public int reward;

    //score from 1-100 
    public int waterNeeds;
    public int sunNeeds;
    public int foodNeeds;

    public List<GameObject> seedStages;

    public GameObject GetPrefabByStage(int stage)
    {
        if(stage > seedStages.Count) return null;

        return seedStages[stage];
    }
}
