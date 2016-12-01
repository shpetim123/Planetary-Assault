using UnityEngine;
using System.Collections;

public class PlayerAimLine : MonoBehaviour
{
    Transform planet;
    public Color c1 = Color.blue;
    public float lineLength;
	// Use this for initialization
	void Start ()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform;
        lineLength = Vector3.Distance(planet.transform.position, transform.position);
        LineRenderer line = gameObject.AddComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(c1, c1);
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount((int)lineLength);
	}
	
	// Update is called once per frame
	void Update ()
    {
        LineRenderer line = GetComponent<LineRenderer>();
        int i = 0;

        while (i < lineLength)
        {
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, 20);
            Vector3 targPos = new Vector3(planet.position.x, planet.position.y, 20);
            line.SetPosition(0, pos);
            line.SetPosition(1, targPos);
            i++;
        }
	}
}
