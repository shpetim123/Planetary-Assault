using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Transform planet;           //used to store a planet transform.

    Transform bg;               //background
    Vector3 mousePos;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    Transform cam;

	// Use this for initialization
	void Start () 
    {
        //Cursor.lockState = CursorLockMode.Locked;Cursor.lockState = CursorLockMode.Locked;
        planet = GameObject.FindGameObjectWithTag("Planet").transform;        
        bg = GameObject.FindGameObjectWithTag("BG").transform;
        cam = GameObject.FindGameObjectWithTag("MinimapCam").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Controls();
        RotateToPlanet();
	}

    void Controls()
    {
        float rotP = 10f; //rot stands for rotate or rotation
        float rotBG = 4f;

    //    mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));      //this gets the mouse position and stores it in a vector called mouse pos. 

        if (Input.GetKey(KeyCode.A))
        {
            planet.Rotate(-Vector3.forward * rotP * Time.deltaTime);
            cam.Rotate(-Vector3.forward * rotP * Time.deltaTime);
            bg.Rotate(-Vector3.forward * rotBG * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            planet.Rotate(Vector3.forward * rotP * Time.deltaTime);
            cam.Rotate(Vector3.forward * rotP * Time.deltaTime);
            bg.Rotate(Vector3.forward * rotBG * Time.deltaTime);
        }

        float h = horizontalSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
        float v = verticalSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;
        Vector3 nextpos = transform.position + new Vector3(h, v, 0); 
        if (nextpos.x < 8.2 && nextpos.x > -8.2 && nextpos.y < 4.5 && nextpos.y > -1.8) transform.Translate(h, v, 0);
    //    transform.position = Vector3.Lerp(transform.position, mousePos, 2 * Time.deltaTime);         //this then user linear interpolation to smooth out the trasnition from ships position to mouse.
        
    }

    void RotateToPlanet()
    {
        Vector3 pos = transform.position;
        Vector3 dir = planet.position - pos;

        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, -dir);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 1.75f);
        transform.rotation = rotation;
    }
}
