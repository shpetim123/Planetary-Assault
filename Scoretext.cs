using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoretext : MonoBehaviour {

    Text sText;

    void UpdateScoreUI() 
    {
        sText.text = "" +PlayerState.instance.pScore;
      //  GetComponent<Text>().text = sText.text;
    }


	// Use this for initialization
	void Start () {
        sText = GetComponent<Text>(); 
        PlanetAttackState.instance.BuildingDestroyed += UpdateScoreUI;
        sText.text = ""+ PlayerState.instance.pScore;
	}
	
	// Update is called once per frame
	void Update () {

        sText.text = "" + PlayerState.instance.pScore;
	}
}
