using System.Security.AccessControl;
using System.Collections;
using UnityEngine;

[System.Serializable]
    public class BasicStats
    {
        [Header("Status Base")]
        public float startLife;
        public float startMana;
        public int stranght;
        public int inteligence;
        public int agility;
        public int baseDefense;
        public int baseAttack;
    }

public abstract class CharacterBase : MonoBehaviour
{
    
    public int currentLevel;
    public BasicStats basicStats;

    
 

    // Start is called before the first frame update
    protected void Start()
    {
        
    } 

    // Update is called once per frame
    protected void Update()
    {
        
    }
}
