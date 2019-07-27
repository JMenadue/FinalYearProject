using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class Menu : MonoBehaviour
{

    public GameObject buttonHolder;

    public bool buttonEnabled;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions._default.MenuButton.GetStateDown(SteamVR_Input_Sources.Any) || SteamVR_Actions._default.MenuButton.GetStateUp(SteamVR_Input_Sources.Any))
        {
            buttonHolder.SetActive(!buttonEnabled);
            buttonEnabled = !buttonEnabled;
        }
    }


}
