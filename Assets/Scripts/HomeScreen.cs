using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void MoveToScene(int SceneID)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneID);
    }

}
