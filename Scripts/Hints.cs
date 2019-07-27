using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class Hints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnHandHoverBegin(Hand hand)
    {
        ControllerButtonHints.ShowButtonHint(hand, SteamVR_Actions._default.GrabPinch);
    }

    private void OnHandHoverEnd(Hand hand)
    {
        ControllerButtonHints.HideButtonHint(hand, SteamVR_Actions._default.GrabPinch);
    }
}
