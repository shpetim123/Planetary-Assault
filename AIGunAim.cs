using UnityEngine;
using System.Collections;

public class AIGunAim : MonoBehaviour 
{
    Transform player;
    // Use this for initialization
	void Start () 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        RotateToPlayer();
	}

    void RotateToPlayer()
    {
        //Commented out code is for mouse tracking. New code is for player tracking.
        //Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        //Vector3 dir = Input.mousePosition - pos;
        Vector3 pos = transform.position;
        Vector3 dir = player.position - pos;
        //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 1.75f);

        //transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        //transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, Time.time);
    }
}
