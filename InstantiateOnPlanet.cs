using UnityEngine;
using System.Collections;

public class InstantiateOnPlanet : MonoBehaviour
{

 public static Transform DoInstantiate(Transform prefab,Transform planet)
    {
        Transform go = (Transform)GameObject.Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        Transform goTransform;
        goTransform = go.GetComponent<Transform>();
        goTransform.parent = planet.transform;
        goTransform.position = planet.position;
        goTransform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
        goTransform.Translate(new Vector3(0, planet.GetComponent<CircleCollider2D>().radius * planet.localScale.x + 0.3f));
        return go;
    }

}
