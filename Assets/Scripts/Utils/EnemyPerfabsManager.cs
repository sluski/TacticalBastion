using System;
using UnityEngine;

public class EnemyPerfabsManager : MonoBehaviour {

    public static EnemyPerfabsManager Instance;
    
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    private void Awake() {
        if(Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public GameObject GetPrefabByEnum(EnemyEnum enemyEnum) {
        switch(enemyEnum) {
            case EnemyEnum.Enemy1: return enemy1;
            case EnemyEnum.Enemy2: return enemy2;
            case EnemyEnum.Enemy3: return enemy3;
            default: throw new ArgumentException($"EnemyEnum value {enemyEnum} does not supported");
        }
    } 

}