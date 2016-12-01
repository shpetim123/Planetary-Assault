using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    Transform DetectPlayer()
    {
        Transform target = null;
        int radius = 10;
        //Array of colliders within area
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

        //if no target has been found, look for one
        if (!target)
        {
            //iterate through all colliders within the radius
            for (int i = 0; i < colliders.Length; )
            {
                //if this object has found itself
                if (colliders[i].transform == transform)
                {
                    i++;
                }
                //if a player has been found, assign it's transform to target
                else if (colliders[i].gameObject.tag == "Player")
                {
                    //target = colliders[i].transform;
                    //MISSION DETAILS TO APPEAR HERE (LEVEL NAME, DIFFICULTY ETC)
                }
                else
                {
                    i++;
                }
            }
        }
        return target;
    }

    void OnCollisionEnter2D(Collider2D col)
    {
        //Load Level Here
        //Application.LoadLevel("LevelName");
        print("Load me!");
    }
}