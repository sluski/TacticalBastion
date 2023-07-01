using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour {

    [SerializeField] protected float health;

    public void TakeDamage(float damage) {
        health -= damage;
        if(health <= 0) {
            DestroyMe();
        }
    }

    protected abstract void DestroyMe(); 

}
