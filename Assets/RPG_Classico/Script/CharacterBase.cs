using System.Collections;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    [Header("Status Base")]
    public int currentLevel;
    public float startLife;
    public float startMana;
    public int stranght;
    public int inteligence;
    public int agility;
    public int baseDefense;
    public int baseAttack;

    // Start is called before the first frame update
    protected void Start()
    {
        
    } 

    // Update is called once per frame
    protected void Update()
    {
        
    }
}
