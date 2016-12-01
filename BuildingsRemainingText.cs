using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuildingsRemainingText : MonoBehaviour
{

    Text bText;

    void UpdatebRemainingUI()
    {
        bText.text = "Buildings Required: " + (PlanetAttackState.instance.GetComponent<BuildingSpawner>().numberOfBuildings -1);
        //  GetComponent<Text>().text = sText.text;
    }


    // Use this for initialization
    void Start()
    {
        bText = GetComponent<Text>();
        PlanetAttackState.instance.BuildingDestroyed += UpdatebRemainingUI;
        bText.text = "Buildings Required: " + (PlanetAttackState.instance.GetComponent<BuildingSpawner>().numberOfBuildings);

    }

    // Update is called once per frame
    void Update()
    {


    }
}
