using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialougeDisplay1 : MonoBehaviour
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
        ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
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
                dialogue.SetActive(true);
                ArtChar2.SetActive(true);
                Char1Name.text = "";
                Char1speech.text = "Auf der Suche nach deinem personal space bist du durch ein Wurmloch in eine ferne " +
                                   "Galaxie gereist. Während du dich nach geeigneten Planeten umschaust, fällt dir auf," +
                                   " dass es mal wieder höchste Zeit zu Tanken ist.";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 2:
                Char1Name.text = "";
                Char1speech.text = "Also hälst du am nächstgelegen Stern um deine Energiereserven zu füllen. \n" +
                                   "Während dein Raumschiff sich genüsslich am Licht des Sternen labt hörst du auf einmal " +
                                   "seltsame Geräusche";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 3:
                Char1Name.text = "???";
                Char1speech.text = "*polter polter*";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            //nachschauen oder verstecken
            case 4:
                Char1Name.text = "";
                Char1speech.text = "Du überlegst, was du jetzt tun sollst...";
                Char2name.text = "";
                Char2speech.text = "";
                Choice1AText.text = "verstecken";
                Choice1BText.text = "nachsehen";
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
                allowSpace = false;
                nextButton.SetActive(false);
                break;
            case 6:
                Char1Name.text = "Du";
                Char1speech.text = "Hallo? Wer ist da? Bitte lassen Sie mich in Ruhe! Alles was ich will ist " +
                                   "mein personal space!";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 7:
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(false);
                Char1Name.text = "???";
                Char1speech.text = "HA? Personal space? Das wirst du hier nicht finden! Alles was es hier gibt, bin " +
                                   "ich. Deine personal space-waifu.";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 8:
                ArtChar1.SetActive(false);
                ArtChar2.SetActive(true);
                Char1Name.text = "Du";
                Char1speech.text = "Oh nein... Nicht eine space waifu. Von euch habe ich schon gehört. Ihr verfolgt " +
                                   "arme Reisende solange, bis sie mit euch ein space-harem bilden! Der schlimmste " +
                                   "Feind der personal space Suchenden... Bitte lass mich einfach in Ruhe!";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 9:
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(false);
                Char1Name.text = "Space-Waifu";
                Char1speech.text = "Vergiss es! Von dem bisschen personal space, den du noch besitzt kannst du dich " +
                                   "verabschieden. Ich werde von nun an für immer in deinem space-harem sein!";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 10:
                ArtChar1.SetActive(false);
                ArtChar2.SetActive(true);
                Char1Name.text = "Du";
                Char1speech.text = "Niemals! Nur über meine Leiche!";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 11:
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(false);
                Char1Name.text = "Space-Waifu";
                Char1speech.text = "Das kannst du gerne haben! Du denkst du könntest meine space-love abwehren?" +
                                   "Dann zeig mal was du kannst!";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 12:
                SceneManager.LoadScene("MG_Yudini");
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
