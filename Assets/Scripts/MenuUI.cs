using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Text nameText;
    public static string currentPlayerName;
   
    public void StartButton()
    {     
        currentPlayerName = nameText.text;
        
        SceneManager.LoadScene(1);
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
