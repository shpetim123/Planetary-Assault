using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

    public void LoadLevels(string levelName)
    {
        Application.LoadLevel(levelName);

    }
}
