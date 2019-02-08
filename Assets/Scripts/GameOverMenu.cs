using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    
    public Canvas quitMenu;
    public Button restartText;
    public Button exitText;
    // Use this for initialization
    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        restartText = restartText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
    }

    public void ExitPress()
    {
        quitMenu.enabled = true;
        restartText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        restartText.enabled = true;
        exitText.enabled = true;
    }
    public void StartLevel()
    {
        Application.LoadLevel(3);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
