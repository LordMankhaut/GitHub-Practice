using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButton : MonoBehaviour
{
    public void OnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}