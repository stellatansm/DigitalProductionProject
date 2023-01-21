using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnd = false;

    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Lmao you died");
            Restart();
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
