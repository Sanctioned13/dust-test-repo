using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionScript : MonoBehaviour
{

    public GameObject actionMenu;

    public GameObject chat;

    public Button talkButton;
    public Button dismissButton;

    bool dismissed = false;


    // Start is called before the first frame update
    void Start()
    {
        talkButton.onClick.AddListener(openChat);
        dismissButton.onClick.AddListener(dismissButtonClicked);
    }

    private void dismissButtonClicked()
    {
        Debug.Log("Dismiss");
        dismiss();//throw new NotImplementedException();
    }

    private void dismiss()
    {
        actionMenu.active = false;
        chat.active = false;
        dismissed = true;
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x*-1, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        //throw new NotImplementedException();
    }

    private void openChat()
    {
        Debug.Log("Opening  chat");
        chat.active = true;

        ChatSystemScript.talkerName.Add("Trainer");
        ChatSystemScript.dialogue.Add("Yes, I imagine you are. With your actions this morning, you missed out on breakfast.");
        ChatSystemScript.talkerName.Add("Dust");
        ChatSystemScript.dialogue.Add("Ah, yes, well, things happen...");
        ChatSystemScript.talkerName.Add("Trainer");
        ChatSystemScript.dialogue.Add("Best to get something in you before you pass out.");
        ChatSystemScript.talkerName.Add("Dust");
        ChatSystemScript.dialogue.Add("Agreed!");
    }

    // Update is called once per frame
    void Update()
    {
        if(dismissed == true)
        {
            Vector3 newp = gameObject.transform.localPosition;
            newp += gameObject.transform.right * Time.deltaTime * 100;
            gameObject.transform.localPosition = newp;
        }
    }

    public void showActionChoiceMenu()
    {
        actionMenu.active = true;
    }
}
