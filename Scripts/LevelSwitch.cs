using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelSwitch : MonoBehaviour
{
    public AudioSwitch audioswitchScript;
    public Menu menuScript;
    public GameObject room1;
    public GameObject TeleportArea;
    public GameObject room2;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void Room1()
    {
        Valve.VR.SteamVR_LoadLevel.Begin("Room1");
        Debug.Log("BEGIN");
        room1.transform.position = new Vector3(0, 1, 0);

        //TeleportArea.transform.localScale = new Vector3(0.3f, 1, 0.3f);

        room2.transform.position = new Vector3(0, -100, 0);
        player.transform.position = new Vector3(0, 0, -1);


    }

    public void Room2()
    {
        Valve.VR.SteamVR_LoadLevel.Begin("Room2");
        Debug.Log("BEGIN");
        room1.transform.position = new Vector3(0,-100, 0);
        room2.transform.position = new Vector3(0, 1, 0);
        player.transform.position = new Vector3(0, 0, 0);


    }


}
