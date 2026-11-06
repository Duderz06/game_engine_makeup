using UnityEngine;
using UnityEngine.SceneManagement;

public class titletogame : MonoBehaviour
{
    public string SceneName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void GoToScene() {


        SceneManager.LoadScene(SceneName);


    }

}
