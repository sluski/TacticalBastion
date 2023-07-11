using UnityEngine;

public class EnemyBase : MonoBehaviour {

    [SerializeField] private EnemyData enemyData;

    public EnemyData EnemyData {
        get { return enemyData; }
    }
}