using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Stopwatch _stopwatch;

    public Gladiator[] gladiators;

    private void Awake()
    {
        _stopwatch = new Stopwatch();
    }

    private void Start()
    {
        _stopwatch.Start();
        foreach (Gladiator gladiator in gladiators)
        {
            gladiator.Weapon = Weapon.Bow;
        }
    }

    private void Update()
    {
        if (_stopwatch.ElapsedMilliseconds > 3 * 1000)
        {
            _stopwatch.Restart();
            gladiators[0].Attacca(gladiators[1]);
            gladiators[1].Attacca(gladiators[0]);
        }
    }

    public void FineDeiGiochi(Gladiator perdente)
    {
        foreach (Gladiator gladiator in gladiators)
        {
            if (gladiator == perdente)
            {
                
            }
            else
            {
                gladiator.Victory();
            }
        }
    }
}
