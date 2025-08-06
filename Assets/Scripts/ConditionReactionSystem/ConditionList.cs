using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewConditionList", menuName = "ConditionReaction/ConditionList")]
public class ConditionList : ScriptableObject
{
    public List<Condition> conditions = new List<Condition>();
    public List<Reaction> reactions = new List<Reaction>();
}