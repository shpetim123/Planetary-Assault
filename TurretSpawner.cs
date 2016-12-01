using UnityEngine;
using System.Collections;

public class TurretSpawner : MonoBehaviour
{

    public int numberOfTurrets = 15;
    public Transform[] turrets;
    public Transform planet;
    public Transform turretPrefab;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < numberOfTurrets; i++)
        {
            turrets[i] = InstantiateOnPlanet.DoInstantiate(turretPrefab, planet);
            turrets[i].Translate(new Vector3 (0,-0.3f,-2));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}