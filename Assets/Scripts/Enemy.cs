using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 500;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
            DieMadafaka();
    }

    private void DieMadafaka()
    {
        Debug.Log("Madafaka Died");
        animator.SetBool("EnemyDie",true);
        Destroy(gameObject, 2f);
    }
}
