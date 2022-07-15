using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeCharacter 
{
    Warrior,
    Wizard,
    Elf,
}

public abstract class PlayerBehaviour : CharacterBase
{
    public TypeCharacter type;

    // Start is called before the first frame update
    protected void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
