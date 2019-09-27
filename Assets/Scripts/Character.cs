using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Character", order = 1)]
public class Character : ScriptableObject
{
    public string prefabName;

    public float health;
    public float strenght;
    public float agility;
    public float intelligence;

    public float bowAbility;
    public float shieldAbility;
    public float swordAbility;
    
    public Texture2D texture;
}

public enum Weapon
{
    Bow, Shield, Sword
}

public enum Stat
{
    Health, Strenght, Agility, Intelligence
}
