using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Gladiator : CharacterStat
{
    public UnityEvent death;
    public Weapon Weapon { get; set; }
    private Dictionary<Stat, float> _remainingStats;

    private void Start()
    {
        _remainingStats = new Dictionary<Stat, float>(stats);
    }

    public void Attacca(Gladiator enemy)
    {
        Urla( "Attacco " + enemy.root.prefabName);
        enemy.Colpito(1);
    }

    public void Colpito(float dmg)
    {
        Urla("sono stato colpito");
        _remainingStats[Stat.Health] -= dmg;
        if (_remainingStats[Stat.Health] <= 0)
        {
            this.Morte();
        }
    }

    public void Victory()
    {
        base.Victory(Weapon, _remainingStats);
        Urla("nuove statistiche (hp=" + stats[Stat.Health] + ")");
    }
    
    private void Morte()
    {
        death.Invoke();
        Urla("Morto con onore");
    }

    private void Urla(string msg)
    {
        Debug.Log(base.characterName + ": " + msg);
    }
}
