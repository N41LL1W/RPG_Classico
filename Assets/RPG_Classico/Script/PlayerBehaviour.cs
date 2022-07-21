using System.Collections;
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

        basicStats = PlayerStatsController.intance.GetBasicStats(type);
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }
}
