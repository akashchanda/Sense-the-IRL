using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConfig : MonoBehaviour
{
    public GameObject Interface;

    void Start()
    {
        Debug.Log(SceneManager.sceneCountInBuildSettings);
        Debug.Log(Interface.transform.childCount);
    }

    // Scene_loader loads the scene clicked on
    public void Scene_loader(string scene_name)
    {
        Debug.Log("In Scene_loader");
        SceneManager.LoadScene(scene_name);
    }


    // Update is called once per frame
    void Update()
    {

    }

}
