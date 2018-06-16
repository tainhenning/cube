using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool ended = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void EndGame()
    {
        if(!ended)
        {
            ended = true;
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene("Level01");
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

}
