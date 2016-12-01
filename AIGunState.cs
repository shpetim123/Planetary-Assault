using UnityEngine;
using System.Collections;

public class AIGunState : MonoBehaviour 
{
    private AIGunAim aiGunAim;
    private AIGunFire aiGunFire;
    public int shootdistance = 15;
   Transform cam;
	// Use this for initialization
	void Start () 
    {
        aiGunAim = GetComponent<AIGunAim>();
        aiGunFire = GetComponent<AIGunFire>();
        aiGunAim.enabled = false;
        aiGunFire.enabled = false;
        cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Vector2.Distance(cam.position, transform.position) > shootdistance)
        {
            aiGunAim.enabled = false;
            aiGunFire.enabled = false;
        }
        else
        {
            aiGunAim.enabled = true;
            aiGunFire.enabled = true;
        }

	}

  //  void OnBecameVisible()
  //  {
  //      aiGunAim.enabled = true;
  //      aiGunFire.enabled = true;
  //  }

 //   void OnBecameInvisible()
  //  {
 //       aiGunAim.enabled = false;
 //       aiGunFire.enabled = false;
 //   }
}
