using UnityEngine;
using UnityEngine.Events;

public abstract class Condition: ScriptableObject
{
    public abstract bool Evaluate(GameObject target);
}
