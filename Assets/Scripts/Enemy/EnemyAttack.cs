using UnityEngine;

public class EnemyAttack : MonoBehaviour {
    [SerializeField] private EnemyData enemyData;

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Wall")) {
            var healthComponent = collision.gameObject.GetComponent<Health>();
            if(healthComponent != null) {
                healthComponent.TakeDamage(enemyData.damage * GameManager.instance.CurrentDifficulty.damageMultiplier);
            }
            Destroy(gameObject);
        }
    }
}
