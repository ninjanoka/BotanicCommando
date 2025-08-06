using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Reload()
    {
        SceneManager.LoadScene(0);
    }

}
