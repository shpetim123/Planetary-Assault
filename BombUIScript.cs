using UnityEngine;
using System.Collections;

public class BombUIScript : MonoBehaviour {

    GameObject player;
    float timer;
    float timercap;

	// Use this for initialization
	void Start () {
	player = GameObject.FindGameObjectWithTag("Player");
    timer = player.GetComponent<PlayerGunFire>().GetTimer();
    timercap = player.GetComponent<PlayerGunFire>().GetTimerCap();
	}
	
	// Update is called once per frame
	void Update () {

        timer = player.GetComponent<PlayerGunFire>().GetTimer();
        timercap = player.GetComponent<PlayerGunFire>().GetTimerCap();

        this.GetComponent<RectTransform>().sizeDelta = new Vector2((100f / timercap) * (timercap - timer), 100);
	
	}
}
