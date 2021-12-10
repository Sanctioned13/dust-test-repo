using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatSystemScript : MonoBehaviour
{
    //
    public static List<string> talkerName = new List<string> { };
    public static List<string> dialogue = new List<string> { };
    public List<string> talkerNameV = new List<string> { };
    public List<string> dialogueV = new List<string> { };

    //
    public Image trainerCharImg;
    public Image dustCharImg;

    //
    public Text mainDialogueText;
    public Text namePlateText;

    //other
    bool typing = false;
    float typingSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(beginChatLoop());
    }

    IEnumerator beginChatLoop()
    {
        while (1 == 1)
        {
            yield return new WaitForSeconds(typingSpeed);
            if (mainDialogueText.text.Trim().Equals(dialogue[0]) == false)
            {
                namePlateText.text = talkerName[0];
                mainDialogueText.text = dialogue[0].Substring(0, mainDialogueText.text.Length + 1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        {//just to help see stuff in inspector.
            talkerNameV = talkerName;
            dialogueV = dialogue;
        }

        if(talkerName.Count <= 0)//no more dialogue, hide chat.
        {
            gameObject.active = false;
        }

        if(Input.GetMouseButtonDown(0))//left click, prgoress dialogue
        {
            if(mainDialogueText.text.Trim().Equals(dialogue[0]) == false)
            {
                mainDialogueText.text = dialogue[0];
            }
            else
            {
                dialogue.RemoveAt(0);
                talkerName.RemoveAt(0);
                mainDialogueText.text = "";
            }
        }

        //show chars
        trainerCharImg.color = Color.grey;
        dustCharImg.color = Color.grey;
        if (namePlateText.text.Trim().Equals("Trainer"))
        {
            trainerCharImg.color = Color.white;
        }
        else
        {
            dustCharImg.color = Color.white;
        }
    }
}
