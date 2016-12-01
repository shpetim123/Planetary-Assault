using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "E_Missile" || col.gameObject.tag == "E_Bullet")
        {
            PlayerState.instance.pHealth -= col.gameObject.GetComponent<ProjectileDamage>().GetDamage();
            Destroy(col.gameObject);
        }

    }
}
