using UnityEngine;

[CreateAssetMenu(fileName = "NewGrowReaction", menuName = "ConditionReaction/Reactions/GrowReaction")]
public class GrowReaction : Reaction
{
    public string message;

    public override void Execute(GameObject target)
    {
        Debug.Log($"{message} triggered on {target.name}");
    }
}