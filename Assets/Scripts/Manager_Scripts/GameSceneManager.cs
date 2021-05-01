using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{

    public GameObject _restartButton;
    public GameObject _quitButton;
    public GameObject _EscPanel;
    public static int _highscore;            // The player's score.
    public Text _highScoreText;
    public Text _scoreText;
    public Text _lifeText;
    public Text _upgradeText;
    public bool _isEscPanelActive = false;
    float _instantiateTime = 0;
    public static bool _upgradeWeapon; 


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        _upgradeText.enabled = false;
        EnemyCollusion._remainingLife = 3;
        _EscPanel.SetActive(false);
        BulletCollusion._score = 0;
        EnemyCollusion._restartButton = false;
        EnemyCollusion._quitButton = false;
        _quitButton.SetActive(false);
        _restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score: " + BulletCollusion._score;
        _highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("highscore", 0);
        _lifeText.text = "Life: " + EnemyCollusion._remainingLife;

        if (EnemyCollusion._restartButton && EnemyCollusion._quitButton)
        {
            _quitButton.SetActive(true);
            _restartButton.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) //Pause game when escape is pressed
        {
            if (_isEscPanelActive)
            {
                unPause();
            }
            else
            {
                pause();
            }

        }

        if (BulletCollusion._score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", BulletCollusion._score);
        }

        if(_upgradeWeapon == true)
        {
            _instantiateTime += Time.deltaTime;
            _upgradeText.enabled = true;

            if (_instantiateTime > 3)
            {
                _instantiateTime = 0;
                _upgradeWeapon = false;
                _upgradeText.enabled = false;
            }
            _upgradeText.text = "Minigun Activated";
        }

       
    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quit()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void pause()
    {
        Time.timeScale = 0;
        _EscPanel.SetActive(true);
        _isEscPanelActive = true;
    }

    public void unPause()
    {
        Time.timeScale = 1;
        _EscPanel.SetActive(false);
        _isEscPanelActive = false;
    }


}
