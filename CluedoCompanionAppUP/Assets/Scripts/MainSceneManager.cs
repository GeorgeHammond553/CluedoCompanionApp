using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{

    public void AppTutorial()
    {
        SceneManager.LoadScene("App Tutorial");
    }

    public void CluedoTutorial()
    {
        SceneManager.LoadScene("Cluedo Tutorial");
    }

    public void GameSetup()
    {
        SceneManager.LoadScene("Game Setup");
    }

    public void MainScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void PlayerSheet()
    {
        SceneManager.LoadScene("PlayerSheet");
    }

    public void DiceRoller() 
    {
        SceneManager.LoadScene("DiceRoller");
    }

    //public void *ENTERSCENE NAME HERE*()         *GEORGE - NO SPACES*
    //{
    //    SceneManager.LoadScene("*ENTERSCENE NAME HERE*");      *GEORGE - NO SPACES*
    //}  *REMEMBER TO ADD NEW SCENES TO THE SCENE LIST IN SETTINGS OR IT WONT WORK* 

}