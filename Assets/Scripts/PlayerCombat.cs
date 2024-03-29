﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackpoint;
    public float attackrange = .5f;
    public LayerMask enemylayer;

    private int coinCount=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.Q) && coinCount >= 3)
        {
            Debug.Log("Special Attacked!");
        }

    }


    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position,attackrange,enemylayer);

        foreach (Collider2D enemy in hitEnemies)
            enemy.GetComponent<Enemy>().TakeDamage(1);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coinCount++;
        }
    }
}
