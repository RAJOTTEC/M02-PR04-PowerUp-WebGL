using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : Subject
{
    public bool levelCompleted = false;

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}