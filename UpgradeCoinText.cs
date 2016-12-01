using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeCoinText : MonoBehaviour {

    Text sText;
	// Use this for initialization
	void Start () {
        sText = GetComponent<Text>(); 
	}
	
	// Update is called once per frame
	void Update () {
        sText.text = "" + PlayerState.instance.pScore;
	}
}
