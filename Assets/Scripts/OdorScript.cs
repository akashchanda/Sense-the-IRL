using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class OdorScript : MonoBehaviour
{
    public GameObject[] buttons;
    public string[] texts;
    private string smell;

    private class smellJson
    {
        public string observation;
        public float latitude;
        public float longitude;
    }

    void Start()
    {
        texts = new string[] { "sewage", "fishy", "stale", "sulfur", "peppery", "trash" };
    }
    public void saveSmell(int index)
    {
        if (buttons[index].transform.GetChild(1).gameObject.activeSelf == false)
        {
            buttons[index].transform.GetChild(0).gameObject.SetActive(false);
            buttons[index].transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            buttons[index].transform.GetChild(1).gameObject.SetActive(false);
            buttons[index].transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void sendData()
    {
        bool valueChosen = false;
        for (int i = 0; i < 6; i++)
        {
            if (buttons[i].transform.GetChild(1).gameObject.activeSelf == false)
            {
                smellJson newJ = new smellJson();
                newJ.observation = texts[i];
                newJ.latitude = 45.321f;
                newJ.longitude = -80.123f;
                string jsonStringTrial = JsonUtility.ToJson(newJ);
                valueChosen = true;
                //NetworkingScript.sendJsonPacket(,jsonStringTrial);
            }
        }
        if (valueChosen)
        {
            gameObject.GetComponent<SceneConfig>().Scene_loader("Home");
        }
    }
}
