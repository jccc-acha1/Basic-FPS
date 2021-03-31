using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage
{
    public int health;
    public void TakeDamage() {
        health--;
    }
    private void Update() {
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
