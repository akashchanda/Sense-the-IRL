using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaunaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void send_data() {
        gameObject.GetComponent<SceneConfig>().Scene_loader("Home");
    }
}
