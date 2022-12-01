using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public AsteroidSpawner Spawner;
    public Text Text;

    void Update()
    {
        Text.text = Spawner.Score.ToString();

        if(Spawner.Score > 20)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
