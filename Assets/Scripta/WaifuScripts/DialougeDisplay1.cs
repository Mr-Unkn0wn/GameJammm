using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialougeDisplay1 : MonoBehaviour
{
    public int primeInt = 1;
    public Text Char1Name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject Choice1a;
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
                break;
            case 2:
                ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1Name.text = "Waifu 1";
                Char1speech.text = "hallöchen was geht bruv";
                Char2name.text = "";
                Char2speech.text = "";
                break;
            case 3:
                Char1Name.text = "";
                Char1speech.text = "";
                Char2name.text = "Du";
                Char2speech.text = "Eyyyyyyyy du coole waifu bitte lass mich in ruhe";
                break;
            case 4:
                Char1Name.text = "Waifu 1";
                Char1speech.text = "ey du opfer komm mit jetzt";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
                break;
            case 100:
                Char1Name.text = "Waifu 1";
                Char1speech.text = "Das wahr die falsche entscheidung. die now!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                break;
            case 200:
                Char1Name.text = "";
                Char1speech.text = "";
                Char2name.text = "Du";
                Char2speech.text = "ich verpiss mich girl";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                break;
            default:
                break;

        }
    }

    public void Choice1AFunc() {
        Char1Name.text = "";
        Char1speech.text = "";
        Char2name.text = "Du";
        Char2speech.text = "ich box dich!";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void Choice1BFunc() {
        Char1Name.text = "";
        Char1speech.text = "";
        Char2name.text = "Du";
        Char2speech.text = "tschau kakao";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1() {
        SceneManager.LoadScene("Scenes/Scene2a");
    }

    public void SceneChange2() {
        SceneManager.LoadScene("Scenes/Scene2b");
    }
    
}
