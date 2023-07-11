using UnityEngine;
using System.Collections.Generic;

public class EnemySpowner : MonoBehaviour {
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float spownDelay;
    private float timeSinceLastSpown = 0;

    private Queue<GameObject> spownQueue = new Queue<GameObject>();

    private void Start() {
        GameManager.Instance.OnWaweLoad.AddListener(HandleLoadWaweEvent);
    }

    private void Update() {
        if(spownQueue.Count != 0 && timeSinceLastSpown > spownDelay) {
            Instantiate(spownQueue.Dequeue(), randomEnemyPositon(), Quaternion.identity, transform);
            timeSinceLastSpown = 0;
        }
        timeSinceLastSpown += Time.deltaTime;
    }

    private Vector2 randomEnemyPositon() {
        return new Vector2(Random.Range(minX, maxX), 22f);
    }

    private void HandleLoadWaweEvent(Wawe wawe) {
        foreach(EnemyData enemy in wawe.enemies) {
            spownQueue.Enqueue(EnemyPerfabsManager.Instance.GetPrefabByEnum(enemy.enemyType));
        }
    } 
}
