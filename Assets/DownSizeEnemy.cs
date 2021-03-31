using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownSizeEnemy : MonoBehaviour, IDamage
{
    public int health;
    public void TakeDamage() {
        health--;
        transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
    }
    private void Update() {
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
