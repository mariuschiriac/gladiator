using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    private int _gen;    //stirpe (numero di generazioni)
    
    public Dictionary<Stat, float> stats;
    public Dictionary<Weapon, float> ability;
    public string characterName;
    public Character root;

    private void Awake()
    {
        characterName = root.prefabName;
        stats = new Dictionary<Stat, float>()
        {
            {Stat.Health, root.health},
            {Stat.Agility, root.agility},
            {Stat.Intelligence, root.intelligence},
            {Stat.Strenght, root.strenght}
        };
        ability = new Dictionary<Weapon, float>()
        {
            {Weapon.Bow, root.bowAbility},
            {Weapon.Shield, root.shieldAbility},
            {Weapon.Sword, root.swordAbility}
        };
    }

    public void Victory(Weapon weapon, Dictionary<Stat, float> remainingStats)
    {
        ability[weapon]++;
        stats[Stat.Health]++;
        stats[Stat.Agility]++;
        stats[Stat.Intelligence]++;
        stats[Stat.Strenght]++;
    }

    public float getBowMastery()
    {
        // usa: _bowAbility _int _agi _hp
        return 1;
    }

    public float getShieldMastery()
    {
        // usa: _shieldAbility _hp _str _agi
        return 1;
    }

    public float getSwordMastery()
    {
        // usa: _swordAbility _str, _agi, _int
        return 1;
    }
}
