using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

   [SerializeField] Text textComponent;
   [SerializeField] State startingState;

    State state;


	// Use this for initialization
	void Start () {
        state = startingState;
        textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        var NextStete = state.GetNextStates();

        for (int i = 0; i < NextStete.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = NextStete[i];
            }
        }
        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = NextStete[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = NextStete[1];
        }*/
        textComponent.text = state.GetStateStory();
    }
}
