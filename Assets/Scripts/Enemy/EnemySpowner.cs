using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpowner : MonoBehaviour {
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float spownDelay;
    private float timeSinceSpown = 0;

    void Update() {
        var xPos = Random.Range(minX, maxX);
        if(timeSinceSpown > spownDelay) {
            Instantiate(enemyPrefab, new Vector2(xPos, transform.position.y), Quaternion.identity, transform);
            timeSinceSpown = 0;
        }
        
        timeSinceSpown += Time.deltaTime;
    }
}
