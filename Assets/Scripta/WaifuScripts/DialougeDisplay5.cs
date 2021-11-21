using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialougeDisplay5 : MonoBehaviour
{
    public int primeInt = 0;
    public Text Char1Name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject Choice1a;
    public Text Choice1AText;
    public Text Choice1BText;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;


    private bool allowSpace = true;
    
    // Start is called before the first frame update
    void Start() {
        
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        ArtChar2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    // Update is called once per frame
    void Update() {
        if (allowSpace) {
            if (Input.GetKeyDown("space")) {
                talking();
            }
        }
    }

    public void talking() {
        primeInt = primeInt + 1;

        switch (primeInt) {
            case 1:
                ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1Name.text = "Space-Waifu";
                Char1speech.text = "Neeeeein du hast uns alle besiegt :( Irgendwann werden eir dich schon holen!!";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 2:
                ArtChar1.SetActive(false);
                ArtChar2.SetActive(true);
                Char1Name.text = "";
                Char1speech.text = "Du spürst wie du langsam wieder an personal space gewinnst und driftest einsam und alleine in den weiten Weltraum.";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 3:
                Char1Name.text = "";
                Char1speech.text = "Während du fliegst fällt dir auch, dass du Konrad danken solltest, der dich und die waifus und die wunderschönen Hintergründe " +
                                   "gezeichnet hat. Im gleichen Atemzug dankst du Fabienne für die wunderbaren Raumschiffe, Herzen und Hintergründe.";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 4:
                Char1speech.text = "Endlich darfst du ins Hauptmenü zurückkehren.";
                break;
           
            case 5:
                SceneManager.LoadScene("MainMenu");
                break;
        }
    }

    public void Choice1AFunc() {
        Char1Name.text = "";
        Char1speech.text = "Du versuchst dich hinter deinem Sitz zu verstecken, aber hörst wie das unbekannte " +
                           "Wesen immer näher kommt.";
        Char2name.text = "";
        Char2speech.text = "";
     //   primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void Choice1BFunc() {
        Char1Name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "Du gehst in den hinteren Teil des Schiffes um nachzuschauen.";
        //primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

}
