using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{

    public void GameSetup() 
    {
        SceneManager.LoadScene("Game Setup");
    }

    public void CluedoTutorial()
    {
        SceneManager.LoadScene("Cluedo Tutorial");
    }

    public void AppTutorial()
    {
        SceneManager.LoadScene("App Tutorial");
    }

}
