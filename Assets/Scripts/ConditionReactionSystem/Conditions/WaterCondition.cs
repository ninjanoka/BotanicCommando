using UnityEngine;

[CreateAssetMenu(fileName = "NewWaterCondition", menuName = "ConditionReaction/Conditions/WaterCondition")]
public class WaterCondition : Condition
{
    public float waterThreshold;
    public bool aboveThreshold;

    public override bool Evaluate(GameObject target)
    {
        Seed seed = target.GetComponent<Seed>();
        if (seed == null) return false;
        if(seed.waterLevel > waterThreshold) return true;
        return false;
    }
}