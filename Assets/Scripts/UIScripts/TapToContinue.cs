using UnityEngine.SceneManagement;
using UnityEngine;

public class TapToContinue : MonoBehaviour
{
    public void ContinueGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
