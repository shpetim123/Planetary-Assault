using UnityEngine;
using System.Collections;

public class PlayerMenuMovement : MonoBehaviour {

    float accel;
    public float topSpeed;
    public float slowSpeed;
    public float rot;

    // Use this for initialization
	void Start () 
    {
        accel = 0.0f;
        topSpeed = 40.0f;
        slowSpeed = 15.0f;
        rot = 10.0f;
	}

	// Update is called once per frame
	void FixedUpdate () 
    {
        //call Controls() in fixed update due to physics use
        Controls();
	}

    void Controls()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * accel);
            
        //WAS Controls
        //Forward
        if (Input.GetKey(KeyCode.W))
        {
            if (accel < topSpeed)
            {
                accel += 25.0f * Time.deltaTime;
            }

            if (accel > topSpeed)
            {
                accel = topSpeed;
            }
        }

        //slow down if forwards isn't pressed
        if (!Input.GetKey(KeyCode.W))
        {
            if (accel > 0.0f)
            {
                accel -= slowSpeed * Time.deltaTime;
            }

            if (accel < 1.0f)
            {
                accel = 0.0f;
            }
        }

        //left and right using physics
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddTorque(rot);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddTorque(-rot);
        }
    }
}
