using UnityEngine;
using UnityEngine.Events;

public abstract class Reaction : ScriptableObject
{
        public abstract void Execute(GameObject target);
}

