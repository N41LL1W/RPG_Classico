using System.Security.AccessControl;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseInfoChar
{
    public BasicStats baseInfo;
    public TypeCharacter type;
}

public class PlayerStatsController : MonoBehaviour
{
    public static PlayerStatsController intance;

    public int xpMultiply = 1;
    public float xpFirstLevel = 100;
    public float difficultFactor = 1.5f;
    public List<BasicStats> baseInfoChars;

    // Start is called before the first frame update
    void Start()
    {
        intance = this;
        DontDestroyOnLoad(gameObject);
        Application.LoadLevel("GamePlay");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
            AddXp(100);
        if(Input.GetKeyDown(KeyCode.R))
            PlayerPrefs.DeleteAll();
    }

    public static void AddXp(float xpAdd)
    {
        float newXp = (GetCurrentXp() + xpAdd) * PlayerStatsController.intance.xpMultiply;

        while(newXp >= GetNextXp())
        {
            newXp -= GetNextXp();
            AddLevel();
        }

        PlayerPrefs.SetFloat("currentXp", newXp);
    }

    public static float GetCurrentXp()
    {
        return PlayerPrefs.GetFloat("currentXp");
    }

    public static int GetCurrentLevel()
    {
        return PlayerPrefs.GetInt("currentLevel");
    }

    public static void AddLevel()
    {
        int newLevel = GetCurrentLevel() + 1;
        PlayerPrefs.SetInt("currentLevel", newLevel);
    }

    public static float GetNextXp()
    {
        return PlayerStatsController.intance.xpFirstLevel*(GetCurrentLevel()+1)*PlayerStatsController.intance.difficultFactor;
    }

    public static TypeCharacter GetTypeCharacter()
    {
        int typeId = PlayerPrefs.GetInt("TypeCharacter");

        if(typeId == 0)
            return TypeCharacter.Warrior;
        else if(typeId == 1)
            return TypeCharacter.Wizard;
        else if(typeId == 2)
            return TypeCharacter.Archer;

        return TypeCharacter.Warrior;
    }

    public static void SetTypeCharacter(TypeCharacter newType)
    {
        PlayerPrefs.SetInt("TypeCharacter", (int) newType);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 50), "Current Xp = " + GetCurrentXp());
        GUI.Label(new Rect(0, 20, 200, 50), "Current Level = " + GetCurrentLevel());
        GUI.Label(new Rect(0, 40, 200, 50), "Current Next Xp = " + GetNextXp());
    }

}

