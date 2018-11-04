using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void sendJsonPacket(string url, string jsonStringTrial)
    {
        //Debug.Log("jsonString: " + jsonStringTrial);
        //Debug.Log("Unpacked: Object is: " + unpacked + " and observation is " + (string)unpacked.observation);
        //Debug.Log("Latitude: " + unpacked.latitude + " longitude: " + unpacked.longitude);
        UnityWebRequest www = UnityWebRequest.Put(url, jsonStringTrial);
        www.SetRequestHeader("Accept", "application/json");
        www.SetRequestHeader("Content-Type", "application/json");
        www.SendWebRequest();
    }

}
