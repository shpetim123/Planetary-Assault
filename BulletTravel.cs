using UnityEngine;
using System.Collections;

public class BulletTravel : MonoBehaviour 
{
    public float speed = 15f;
	// Use this for initialization

	void Start () 
    {
 
	}
	
	// Update is called once per frame
	void Update () 
    {
        Move();
	}

    void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
