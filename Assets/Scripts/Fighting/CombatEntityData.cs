﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEntityData : ScriptableObject
{
    [SerializeField]
    protected StatData baseStats;
    public StatData BaseStats => baseStats;

    [SerializeField]
    protected List<Skill> skills;
    public List<Skill> Skills => skills;

    [SerializeField]
    private int expOnDefeat = 0;
    public int ExpOnDefeat => expOnDefeat;

    public Skill GetRandomSkill()
    {
        if(Skills == null)
        {
            return null;
        }
        return Skills[UnityEngine.Random.Range(0, skills.Count)];
    }
}
