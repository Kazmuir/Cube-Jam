using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//This script is attached to Dialogue Manager Game Object
public class Dialogue : MonoBehaviour
{
    public static Dialogue dialogue;

    public TextMeshProUGUI textDisplay; //references actual TMPro text box inside of Canvas
    public string[] sentences; //an array that will hold sentences, therefore the dialogue will be written in the Dialogue Manager inspector
    private int index;
    public float typingSpeed;

    public bool dialogueEnd = false;

    public GameObject nextButton;
    void Awake()
    {
        dialogue = this;
    }
    private void Start()
    {
        StartCoroutine(Type());
    }

    private void Update()
    {
        if (textDisplay.text == sentences[index]) //after each sentence has fully appeared show the next button.
        {
            nextButton.SetActive(true);
        }
    }
    IEnumerator Type() //paces frames of letters appearing
    {
        yield return new WaitForSeconds(typingSpeed);
        foreach (char letter in sentences[index].ToCharArray()) //show one letter at a time at the speed of typingSpeed
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence() //called when next button is pressed by player
    {
        nextButton.SetActive(false);

        if (index < sentences.Length - 1) //clear text field and move to next sentence in array
        {
            dialogueEnd = false;
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            dialogueEnd = true;
            textDisplay.text = "";
            nextButton.SetActive(false);
        }
    }
}