using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSystem : MonoBehaviour
{
    public static SceneSystem instance;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayAgent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ToSeene(string sceneName)
    {
        name = sceneName;
        SceneManager.LoadScene(name);
    }
    public void TurnMenuGame()
    {

        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}