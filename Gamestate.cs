using UnityEngine;
using System.Collections;

public class Gamestate : MonoBehaviour
{
    bool isPaused = false;
   public bool lvl1Cleared = false;
   public bool lvl2Cleared = false;
   public bool lvl3Cleared = false;
   public bool lvl4Cleared = false;
   public bool lvl5Cleared = false;
   public bool haveplayed = false;

    [SerializeField]

    public static Gamestate instance = null;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Singleton GameState already found...");
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            Object.DontDestroyOnLoad(transform.gameObject);
        }
    }

    void Update()
    {
        //Main Menu
        if (Application.loadedLevel == 0)
        {
            if (lvl1Cleared)
            {
                //Unlock level 2
                //lvl
            }
            if (lvl2Cleared)
            {
                //Unlock level 3
            }
            if (lvl3Cleared)
            {
                //Unlock level 4
            }
            if (lvl4Cleared)
            {
                //Unlock level 5
            }
            if (lvl5Cleared)
            {
                //Player Wins!
            }
        }
    }
}
