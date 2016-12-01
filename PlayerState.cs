using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour
{
	public int pMaxHealth;
    public int pHealth;
    public int pScore;
    public float pFireRate;
    public float pBombCool;
    //public pMoney;



    void Start()
    {
        pHealth = pMaxHealth;
        pFireRate = 0.25f;
        pBombCool = 10f;
    }

    public void StartListening()
    {
        PlanetAttackState.instance.BuildingDestroyed += IncrementScore;
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.P))
        //{
        //    Application.LoadLevel("testscene");
        //}
    }


    void IncrementScore()
    {
        PlayerState.instance.pScore += 100;
        print(pScore);
    }


    public static PlayerState instance = null;

    void Awake()
    {

        if (instance != null)
        {
            Debug.LogError("Singleton PlayerState already found...");
            Destroy(gameObject);
        }
        else
        {
            Cursor.visible = false;
            instance = this;
            Object.DontDestroyOnLoad(transform.gameObject);
        }
    }


}
	// Update is called once per frame

