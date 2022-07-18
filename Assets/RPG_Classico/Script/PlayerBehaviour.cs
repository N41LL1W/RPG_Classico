using System;
using System.Runtime.Intrinsics.Arm.Arm64;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeCharacter
{
    Warrior = 0,
    Wizard = 1,
    Archer = 2
}

public class PlayerBehaviour : CharacterBase
{
    private TypeCharacter type;

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        currentLevel = PlayerStatsController.GetCurrentLevel();
        PlayerStatsController.SetTypeCharacter(TypeCharacter.Archer);
        type = PlayerStatsController.GetTypeCharacter();
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }
}
