using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstatus : MonoBehaviour
{
    public float life;
    public int maxHP;
    public health healthBar;

    private int currentHP;

    private void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        healthBar.UpdateHealth((float)currentHP / (float)maxHP);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            TakeDamage(10);
        }
    }
}
