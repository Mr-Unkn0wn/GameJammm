using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialougeDisplay2 : MonoBehaviour
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
    public GameObject ArtChar3;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject ArtBG3;
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
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        ArtChar2.SetActive(false);
        ArtBG2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtBG3.SetActive(false);
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
                Char1Name.text = "Space-Waifu";
                Char1speech.text = "Ahhhhhhhhhh! Wie? Wie konntest du mich besiegen?";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 2:
                Char1Name.text = "Space-Waifu";
                Char1speech.text = "HA! Aber bilde dir jetzt bloß nicht ein, dass du so einfach" +
                                   "zu deinem personal space gelangen wirst! Ich werde zwar nicht in deinen Harem" +
                                   "können aber hier draußen warten noch viel mehr meiner space-waifu Schwestern!";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 3:
                ArtChar1.SetActive(false);
                Char1Name.text = "";
                Char1speech.text = "Die space-waifu zieht traurig, auf der Suche nach ihren nächstem" +
                                   "Opfer weiter.";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            //nachschauen oder verstecken
            case 4:
                ArtChar3.SetActive(true);
                Char1Name.text = "Du";
                Char1speech.text = "Puh endlich alleine...";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 6:
                Char1Name.text = "Computer";
                Char1speech.text = "Tankvorgang abgeschlossen... Reise zu Planet B-7345c kann " +
                                   "fortgeführt werden";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 7:
                Char1Name.text = "Du";
                Char1speech.text = "Sehr gut... Computer, starte Reise mit Lichtgeschwindigkeit";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 8:
                ArtBG1.SetActive(false);
                ArtBG3.SetActive(true);
                Char1Name.text = "";
                Char1speech.text = "*flieg flieg*";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 9:
                Char1Name.text = "";
                Char1speech.text = "*ratter ratter crash crash*";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 10:
                Char1Name.text = "Computer";
                Char1speech.text = "Fehler! Fehler! Triebwerke ausgefallen. Notlandung einleiten.";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 11:
                Char1Name.text = "Du";
                Char1speech.text = "Oh nein! Das kann nur wieder eine space-waifu sein";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 12:
                ArtChar2.SetActive(true);
                ArtChar3.SetActive(false);
                Char1Name.text = "Space-Waifu";
                Char1speech.text = "Aha! Du! Von dir hab ich schon gehört! Dir ist es gelungen meiner" +
                                   "Schwester zu entkommen. Jetzt musst du dich mit stellen!";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 13:
                SceneManager.LoadScene("Scenes/MGYudiniScenes/MG_Yudini");//zu Flappy bird
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
