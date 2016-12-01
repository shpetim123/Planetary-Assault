using UnityEngine;
using System.Collections;

public class PlayerLaser : MonoBehaviour {

	Transform trans;
    public float speed;
	// Use this for initialization
	void Start () 
    {
        trans = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Travel();
	}

    void Travel()
    {
        trans.Translate(-Vector3.up * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}