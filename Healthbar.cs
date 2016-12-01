using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	this.GetComponent<RectTransform>().sizeDelta = new Vector2(( 100f / PlayerState.instance.pMaxHealth) * PlayerState.instance.pHealth ,100);
	}
}
