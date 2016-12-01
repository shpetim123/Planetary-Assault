using UnityEngine;
using System.Collections;

public class WinLoseConditions : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    void Win()
    {
        if (GetComponent<BuildingSpawner>().numberOfBuildings <= 0)
        {
            print("AHH");
        }
    }

    void Lose()
    {
        if (PlayerState.instance.pHealth <= 0)
        {
            //Player Lose
        }
    }
}
