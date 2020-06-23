
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public bool HasEnded = false;

    public void EndGame()
    {
        if (HasEnded == false)
        {
            HasEnded = true;
            Debug.Log("Game Over");
            Restart();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
