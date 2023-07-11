using UnityEngine;

public class EnemyAttack : MonoBehaviour {
    private EnemyBase enemyBase;

    private void Awake() {
        enemyBase = GetComponent<EnemyBase>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Wall")) {
            var healthComponent = collision.gameObject.GetComponent<Health>();
            if(healthComponent != null) {
                healthComponent.TakeDamage(enemyBase.EnemyData.damage * GameManager.Instance.CurrentDifficulty.damageMultiplier);
            }
            Destroy(gameObject);
        }
    }
}
