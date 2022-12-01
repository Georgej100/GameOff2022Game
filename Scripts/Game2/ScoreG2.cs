using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreG2 : MonoBehaviour
{

    public Transform Player;
    public Text Text;

    void Update()
    {
        int Cms = Mathf.RoundToInt(Player.position.y);
        if(Cms < 0)
        {
            Cms = 0;
        }else if(Cms == 85)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        Text.text = Cms.ToString() + "m";
    }
}
