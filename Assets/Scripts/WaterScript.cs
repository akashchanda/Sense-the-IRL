using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WaterScript : MonoBehaviour
{
    public Slider slider;
    //water clarity value to be submitted
    public float water_clarity = 0.5f;
    public bool microorganisms_is_true = false;
    public bool clarity_changed = false;
    public GameObject water_interface;
    public GameObject info_interface;
    private NetworkScript NetworkingScript;
    //MAKE SURE TO POPULATE
    private string clarityURL;
    private string microorganismsURL;

    void Start()
    {
        NetworkingScript = gameObject.GetComponent<NetworkScript>();
    }

    private class clarityJson
    {
        public float observation;
        public float latitude;
        public float longitude;
    }

    private class microorganismsJson
    {
        public bool observation;
        public float latitude;
        public float longitude;
    }

    public void setTrue()
    {
        microorganisms_is_true = true;
    }

    //only save slider values for submission that user intends to submit
    public void clarityChangeSubmitted(GameObject obj)
    {
        clarity_changed = true;
    }

    public void switchInterfaces(int layer)
    {
        //layer 0 is the main interface and 1 the popup
        if (layer == 0)
        {
            info_interface.gameObject.SetActive(false);
            water_interface.gameObject.SetActive(true);
        }
        else
        {
            water_interface.gameObject.SetActive(false);
            info_interface.gameObject.SetActive(true);
        }
    }

    //submit json form
    public void submitForm()
    {
        if (!clarity_changed && !microorganisms_is_true)
        {
            return;
        }
        string jsonStringTrial;
        if (clarity_changed)
        {
            //submit clarity
            clarityJson newJ = new clarityJson();
            newJ.observation = slider.value;
            //need to change
            newJ.latitude = 45.321f;
            newJ.longitude = -80.123f;
            jsonStringTrial = JsonUtility.ToJson(newJ);
            //NetworkingScript.sendJsonPacket(,jsonStringTrial);
        }
        if (microorganisms_is_true)
        {
            //submit microorganisms
            microorganismsJson newJ = new microorganismsJson();
            newJ.observation = true;
            //need to change
            newJ.latitude = 45.321f;
            newJ.longitude = -80.123f;
            jsonStringTrial = JsonUtility.ToJson(newJ);
            //NetworkingScript.sendJsonPacket(,jsonStringTrial);
        }
        gameObject.GetComponent<SceneConfig>().Scene_loader("Home");
    }

}
