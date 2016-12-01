using UnityEngine;
using System.Collections;

public class ProjectileParenting : MonoBehaviour 
{
    Transform planet;
	// Use this for initialization
	void Start () 
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform;
        transform.parent = planet.transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
