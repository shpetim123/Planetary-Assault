﻿using UnityEngine;
using System.Collections;



public class PlayerBlob : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + new Vector3(0, 0, -15);
	}
}
