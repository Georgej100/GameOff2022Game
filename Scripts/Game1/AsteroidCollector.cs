using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidCollector : MonoBehaviour
{
    AsteroidSpawner EntitySpawner;
    GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
        EntitySpawner = GameObject.Find("Spawner").GetComponent<AsteroidSpawner>();
    }

    private void OnCollisionEnter2D(Collision2D Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            Destroy(Player.gameObject);
            EntitySpawner.AliveAsteroids -= 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
