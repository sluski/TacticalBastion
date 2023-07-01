using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField] private EnemyData enemyData;

    void Update() {
        transform.Translate(Vector3.down * enemyData.speed * GameManager.instance.CurrentDifficulty.speedMultiplier * Time.deltaTime);
    }
    
}
