using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{
    public Button continueButton;
    public Button mainMenuButton;

    public GameObject mainMenu;
    public GameObject gamePanel;

    // Start is called before the first frame update
    void Start()
    {
        continueButton.onClick.AddListener(continueButtonClicked);
        mainMenuButton.onClick.AddListener(mainMenuButtonClicked);
    }

    private void mainMenuButtonClicked()
    {
        mainMenu.active = true;

        gameObject.active = false;
    }

    private void continueButtonClicked()
    {
        gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
