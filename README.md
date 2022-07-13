# RPG_Classico
RPG criado a partir do canal Paulo (We Make a Game)

Topics to be created:
1) Character movement;
2) Level system;
3) Skill system;
4) Magic;
5) Cure;
6) Attack;
7) Fight;
8) Simple attack;
9) Combos;
10) Battle system;
11) Inventory;
12) Potion system;
13) Armor;
14) Weapons;
15) Quests;

Created a new project with the name of RPG_Classico, in Core 3D and Unity version 2021.3.1f1.
In this project we created the Scripts, Prefabs and Scenes folders.
And the 1st scene was added, Loader.
The 1st script was created, LevelController.
And in the hierarchy we add an empty object, with the name of LevelController and to it we assign the script just created, (LevelController).
And we make this object a Prefab, throwing it in the Prefabs folder.

Script - LevelController - v.1
using UnityEngine;
using System.Collection;

public class LevelController : MonoBehavior {
  public static LevelController instance;

  public int xpMultiply = 1;
  public float xpFirstLevel = 100;
  public float difficultFactor = 1.5f;

  private float xpNextLevel;

  void Start()
  {
    instance = this;
    DontDestroyOnLoad(gameObject);
    Application.LoadLevel("GamePlay");

    xpNextLevel = xpFirstLevel * (GetCurrentLevel() + 1) * difficultFactor;

    Debug.Log(xpNextLevel);
    PlayerPrefabs.DeleteAll();
    AddXp(10);
    Debug.Log(GetCurrentXp());
  }

  void Update()
  {

  }

  public static void AddXp(float xpAdd)
  {
    float newXp = (GetCurrentXp() + xpAdd) * LevelController.intance.xpMultiply;
    PlayerPrefabs.SetFloat("currentXp", newXp);
  }

  public static float GetCurrentXp()
  {
    returm PlayerPrefs.GetFloat("currentXp");
  }

  public static float GetCurrentLevel()
  {
    returm PlayerPrefs.GetInt("currentLevel");
  }

  public static void AddLevel()
  {
    int newLevel = GetCurrentLevel() + 1;
    PlayerPrefs.SetInt("current Level", newLevel);
  }

 }

}

#End of 1st class.
