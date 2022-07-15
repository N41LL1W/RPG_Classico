using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    public static PlayerStatsController intance;

    public int xpMultiply = 1;
    public float xpFirstLevel = 100;
    public float difficultFactor = 1.5f;

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

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 50), "Current Xp = " + GetCurrentXp());
        GUI.Label(new Rect(0, 20, 200, 50), "Current Level = " + GetCurrentLevel());
        GUI.Label(new Rect(0, 40, 200, 50), "Current Next Xp = " + GetNextXp());
    }

}

