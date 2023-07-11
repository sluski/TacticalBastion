using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Wawe", menuName = "Settings/Wawe")]
public class Wawe : ScriptableObject {
    public new string name;
    public int index;
    public List<EnemyData> enemies = new List<EnemyData>();
}
