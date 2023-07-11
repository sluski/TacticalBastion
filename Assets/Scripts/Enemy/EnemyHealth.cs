using UnityEngine;

public class EnemyHealth : Health {

    private EnemyBase enemyBase;

    private void Awake() {
        enemyBase = GetComponent<EnemyBase>();
        health = Mathf.RoundToInt(enemyBase.EnemyData.health * GameManager.Instance.DifficultyManager.CurrentDifficulty.healthMultiplier);
    }

    protected override void DestroyMe() {
        // todo: jakieś particle czy coś
    }

    
}
