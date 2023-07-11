using UnityEngine;

public class EnemyMovement : MonoBehaviour {
   private EnemyBase enemyBase;

   private void Awake() {
        enemyBase = GetComponent<EnemyBase>();
   }

    void Update() {
        transform.Translate(Vector3.down * enemyBase.EnemyData.speed * GameManager.Instance.CurrentDifficulty.speedMultiplier * Time.deltaTime);
    }
    
}
