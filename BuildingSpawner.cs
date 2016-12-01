using UnityEngine;
using System.Collections;

public class BuildingSpawner : MonoBehaviour {

	public int numberOfBuildings = 30;
	public Transform[] buildings;
	public Transform planet;
    public Transform[] buildingprefabs;
	public Transform buildingPrefab1;
    public Transform buildingPrefab2;
	// Use this for initi alization

    void RemoveBuilding()
    {
        numberOfBuildings--;
        Debug.Log(numberOfBuildings);
    }


	void Start ()
	{
        PlanetAttackState.instance.BuildingDestroyed += RemoveBuilding;
		for (int i = 0; i < numberOfBuildings; i++)
		{
            
            int randnum = Random.Range(0,buildingprefabs.Length);
            print(randnum);
            buildings[i] = InstantiateOnPlanet.DoInstantiate(buildingprefabs[randnum], planet);

		}
	}

	
	// Update is called once per frame
	void Update () {
        if (numberOfBuildings == 0) PlanetAttackState.instance.WinLevel();
	}
}
