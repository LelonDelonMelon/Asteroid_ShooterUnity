using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public GameObject _MainMenuScene;
    public GameObject _CreditScene;
    public GameObject _StoryScene;
    public GameObject _HowToPlayScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void goTocredits()
    {
        _MainMenuScene.SetActive(false);
        _CreditScene.SetActive(true);
    }

    public void goBakcToMainMenu()
    {
        _CreditScene.SetActive(false);
        _StoryScene.SetActive(false);
        _HowToPlayScene.SetActive(false);
        _MainMenuScene.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void goToStory()
    {
        _MainMenuScene.SetActive(false);
        _StoryScene.SetActive(true);
    }

    public void goToHowToPlay()
    {
        _MainMenuScene.SetActive(false);
        _HowToPlayScene.SetActive(true);
    }
}
