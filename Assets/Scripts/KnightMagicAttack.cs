using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMagicAttack : MonoBehaviour
{
    [SerializeField] private float attackDelay;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Projectile[] fireBalls;
    
    private float attackTimer = Mathf.Infinity;
    private Animator anim;
    private bool canAttack;
   
    
    
    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
        canAttack = false;

    }

    // Update is called once per frame
    void Update()
    {
        attackTimer += Time.deltaTime;
       
    }

    public void Attack()
    {
        if (attackTimer > attackDelay)
        {
            anim.SetTrigger("attack");
            Debug.Log("ATTACK");
            attackTimer = 0.0f;

            int index = FindFireball();
            fireBalls[index].transform.position = firePoint.position;
            fireBalls[index].SetDirection(Mathf.Sign(-transform.localScale.x));

            attackTimer = 0;
        }
    }

    private int FindFireball()
    {
        for (int i = 0; i < fireBalls.Length; i++)
        {
            if (!fireBalls[i].gameObject.activeInHierarchy)
            {
                return i;
            }
        }

        return 0;
    }
}