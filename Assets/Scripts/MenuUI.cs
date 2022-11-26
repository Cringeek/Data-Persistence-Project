using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private Text bestScoreText;
    public static string currentPlayerName;


    public void Start()
    {
        DataSave.LoadHighScore();
        bestScoreText.text = $"Best Score: {DataSave.playerName} : {DataSave.score}";
    }

    public void StartButton()
    {     
        currentPlayerName = nameText.text;
        
        SceneManager.LoadScene(1);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
   
    public void QuitButton()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
