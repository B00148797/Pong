using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScenes : MonoBehaviour
{
    public void LoadScene_OnePlayer()
    {
        SceneManager.LoadScene("OnePlayer");
    }
    public void LoadScene_TwoPlayers()
    {
        SceneManager.LoadScene("TwoPlayers");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) Application.Quit();
    }
}
