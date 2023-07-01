using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCannonProjectile : MonoBehaviour {
    

    [SerializeField] private float speed;
    private Vector2 direction;

    public void Initialize(Vector2 direction) {
        this.direction = direction;
    }
    

    void Update() {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

