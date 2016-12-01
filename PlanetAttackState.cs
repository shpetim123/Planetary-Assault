using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class PlanetAttackState : MonoBehaviour
{
    public Action BuildingDestroyed = null;

 //   public void InitBuildingDestroyed()
 //   {
 //      BuildingDestroyed();
 //   }



    [SerializeField]


    GameObject pausedTxt;
    GameObject resumeTxt;
    GameObject quitTxt;
    public float firerate;

    public static PlanetAttackState instance = null;

    void Start()
    {
        pausedTxt = GameObject.FindGameObjectWithTag("Paused") as GameObject;
        resumeTxt = GameObject.FindGameObjectWithTag("Resume") as GameObject;
        quitTxt = GameObject.FindGameObjectWithTag("Quit") as GameObject;

        pausedTxt.SetActive(false);
        resumeTxt.SetActive(false);
        quitTxt.SetActive(false);
        PlayerState.instance.StartListening();
        Gamestate.instance.haveplayed = true;
        PlayerState.instance.pHealth = PlayerState.instance.pMaxHealth;
    }


    public void WinLevel()
    {
        PlayerState.instance.pHealth = PlayerState.instance.pMaxHealth;
        if(Application.loadedLevel == 1) Gamestate.instance.lvl1Cleared = true;
        if(Application.loadedLevel == 2) Gamestate.instance.lvl2Cleared = true;
        if(Application.loadedLevel == 3) Gamestate.instance.lvl3Cleared = true;
        if(Application.loadedLevel == 4) Gamestate.instance.lvl4Cleared = true;
        Application.LoadLevel("MainMenu");
    }

    public void LoseLevel()
    {
        PlayerState.instance.pHealth = PlayerState.instance.pMaxHealth;
        Time.timeScale = 1;
        Application.LoadLevel("MainMenu");

    }   


    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Singleton PlanetAttackState already found...");
        }

        Cursor.visible = false;
        instance = this;
    }
    void Update()
    {
        if (Time.timeScale == 0) { if (Input.GetKeyDown(KeyCode.Escape)) Application.LoadLevel("MainMenu"); };
        PausingGame();

        if (Time.timeScale == 0) { if (Input.GetKeyDown(KeyCode.Escape)) LoseLevel(); };

        if (PlayerState.instance.pHealth <= 0) LoseLevel();
    }

    void PausingGame()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (Time.timeScale == 1)
            {
                pausedTxt.SetActive(true);
                resumeTxt.SetActive(true);
                
                quitTxt.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0;
            }
            else
            {
                pausedTxt.SetActive(false);
                resumeTxt.SetActive(false);
                quitTxt.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1;
            }
        }

    }
}
