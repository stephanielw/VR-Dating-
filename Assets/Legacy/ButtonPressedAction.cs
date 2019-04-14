using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPressedAction : MonoBehaviour
{

    public KeyCode key = KeyCode.Space;
    public int sceneIndex = 0;

    // Update is called once per frame
    void Update()
    {
        //change this input depending on which button triggers the action.
        if(Input.GetKeyDown(key))
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
