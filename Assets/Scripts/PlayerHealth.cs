using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;

    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
   public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
