using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DifficultySettings", menuName = "Settings/Difficulty")]
public class DifficultySettings : ScriptableObject {
    public float healthMultiplier;
    public float damageMultiplier;
    public float speedMultiplier;
}
