using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class IntroHints : MonoBehaviour
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
        ControllerButtonHints.ShowTextHint(hand, SteamVR_Actions._default.GrabPinch, "Press to pick up");
        ControllerButtonHints.ShowButtonHint(hand, SteamVR_Actions._default.GrabPinch);
    }

    private void OnHandHoverEnd(Hand hand)
    {
        ControllerButtonHints.HideButtonHint(hand, SteamVR_Actions._default.GrabPinch);
        ControllerButtonHints.HideTextHint(hand, SteamVR_Actions._default.GrabPinch);
    }
}