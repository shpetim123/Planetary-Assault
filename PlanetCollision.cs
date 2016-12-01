using UnityEngine;
using System.Collections;

public class PlanetCollision : MonoBehaviour
{

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
        /*PLAYER MAY NEED TO BE ADDED HERE AS WELL, BUT DELETING IT HERE MAY CAUSE NULL POINTER ERRORS
         Might be best to, instead of destroying it here, call a function within Player that updates
         their stats, like health and score. At the end of that function, a destroy command could be called.*/
        if (col.gameObject.tag == "Bomb" || col.gameObject.tag == "P_Laser")
        {
            Destroy(col.gameObject);
        }
    }
}
