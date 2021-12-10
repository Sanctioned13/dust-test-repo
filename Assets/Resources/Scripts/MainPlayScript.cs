using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayScript : MonoBehaviour
{


    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controls();
    }

    private void controls()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Pause))
        {
            pauseScreen.active = true;
        }
    }

    public void pauseUiButtonClicked()
    {
        pauseScreen.active = true;
    }
}
