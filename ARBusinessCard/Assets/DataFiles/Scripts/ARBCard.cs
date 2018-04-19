using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARBCard : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject developergo, trainergo, travelergo;

	// Use this for initialization
	void Start () {

        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }
        
        developergo.SetActive(false);
        trainergo.SetActive(false);
        travelergo.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "DeveloperVB")
        {
            Debug.Log("Developer button pressed");
            developergo.SetActive(true);
            trainergo.SetActive(false);
            travelergo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "TrainerVB")
        {
            Debug.Log("Trainer button pressed");
            developergo.SetActive(false);
            trainergo.SetActive(true);
            travelergo.SetActive(false);
        }
        else if (vb.VirtualButtonName == "TravelerVB")
        {
            Debug.Log("Traveler button pressed");
            developergo.SetActive(false);
            trainergo.SetActive(false);
            travelergo.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + " Virtual button not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Traveler button released");

    }
}
