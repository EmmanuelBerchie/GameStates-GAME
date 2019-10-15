using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdventureGame : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI textComponent;
    [SerializeField]
    State startingState;
    
 
    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
       
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
    private void ManageState()
    {
        // Calling get next state , use var to represent state, can only be used once the variable has already been initialised 
        var nextStates = state.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            // if 1 is pressed the index will be updated for instance it will go from 0 to 1 etc. 
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                //Changing states in array, index representing states 
                state = nextStates[index];
            }


        }
        textComponent.text = state.GetStateStory();
       
    }
}