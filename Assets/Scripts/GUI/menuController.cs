using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("Test");
    }

    public void backToMenu(){
        SceneManager.LoadScene("Welcome");
    }

    public void Quit(){
        Application.Quit();
    }
}
