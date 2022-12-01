using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{

    [SerializeField] int TargetInt;
    [SerializeField] bool WithDelay;
    [SerializeField] int Delay;

    void Update()
    {
        if (Input.anyKeyDown && !WithDelay)
        {
            NextScene();
        }

        if(WithDelay)
        {
            Invoke("NextScene", Delay);
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(TargetInt);
    }
}
