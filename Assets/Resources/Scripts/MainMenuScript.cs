using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

    public GameObject playPanel;


    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(playButtonClicked);
        quitButton.onClick.AddListener(quitButtonClicked);
    }

    private void quitButtonClicked()
    {
        Application.Quit();
    }

    private void playButtonClicked()
    {
        playPanel.active = true;
        gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
