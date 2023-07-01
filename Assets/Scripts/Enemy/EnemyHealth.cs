using UnityEngine;

public class EnemyHealth : Health {
    [SerializeField] private EnemyData enemyData;

    private void Awake() {
        health = Mathf.RoundToInt(enemyData.health * GameManager.instance.CurrentDifficulty.healthMultiplier);
    }

    protected override void DestroyMe() {
        // todo: jakieś particle czy coś
    }

    
}
