using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField]
    private int MaxHealth = 100;

    private int CurrentHealth;
    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }
    public void takeDamage(int amount )
    {
        CurrentHealth -= amount;
    }
}
