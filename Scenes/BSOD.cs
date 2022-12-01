using UnityEngine;
using UnityEngine.SceneManagement;

public class BSOD : MonoBehaviour
{
    bool CanProgress = false;

    void Update()
    {
        if (!Input.anyKey)
        {
            CanProgress = true;
        }

        if (Input.anyKey && CanProgress)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
