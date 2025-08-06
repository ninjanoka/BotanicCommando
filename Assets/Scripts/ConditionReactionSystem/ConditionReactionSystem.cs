using System.Collections.Generic;
using UnityEngine;

public class ConditionReactionSystem : MonoBehaviour
{
    public List<ConditionList> conditionLists = new List<ConditionList>();
    public GameObject targetObject;

    void Update()
    {
        foreach (var conditionList in conditionLists)
        {
            if (EvaluateConditions(conditionList.conditions))
            {
                ExecuteReactions(conditionList.reactions);
            }
        }
    }

    bool EvaluateConditions(List<Condition> conditions)
    {
        foreach (var condition in conditions)
        {
            if (!condition.Evaluate(targetObject))
            {
                return false;
            }
        }
        return true;
    }

    void ExecuteReactions(List<Reaction> reactions)
    {
        foreach (var reaction in reactions)
        {
            reaction.Execute(targetObject);
        }
    }
}
