using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidScript : MonoBehaviour
{

    [SerializeField] float MinRX, MaxRX;
    [SerializeField] float MinX = -11.19f;
    [SerializeField] float MaxX = 11.19f;
    [SerializeField] float MinY = -6.356f;
    [SerializeField] float MaxY = 4.395f;
    [SerializeField] float Speed = 0.01f;
    GameObject Spawner;
    bool InBounds;
    bool WasInvoked;
    float Speeed;
    GameObject Player;

    void Start()
    {
        float Rot = Random.Range(MinRX, MaxRX);
        transform.Rotate(0, 0, Rot);

        float Hor = Random.Range(MinX, MaxX);
        transform.position = new Vector3(Hor, 3, 0);

        Spawner = GameObject.Find("Spawner");
        Player = GameObject.Find("Player");
    }

    
    void Update()
    {
        Speeed += 0.009f;
        if(Speeed > Speed)
        {
            Speeed = Speed;
        }

        transform.Translate(0, Speeed, 0);
        CheckIfInBounds();

        if(InBounds == false && !WasInvoked)
        {
            WasInvoked = true;
            KillSwitch();
        }
    }

    void CheckIfInBounds()
    {
        if (transform.position.x > MaxX)
        {
            Bounce();
        }else

        if (transform.position.x < MinX)
        {
            Bounce();
        }else

        if (transform.position.y > MaxY)
        {
            InBounds = false;
        }
        else

        if (transform.position.y < MinY)
        {
            InBounds = false;
        }
        else
        {
            InBounds = true;
        }
    }

    void KillSwitch()
    {
        Destroy(gameObject, 0);
        Spawner.GetComponent<AsteroidSpawner>().DecremetAliveAsteroids();
    }

    void Bounce()
    {
        transform.Rotate(0,0,45);
    }

    void OnCollisionEnter2D(Collision2D Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            Destroy(Player.gameObject);
            SceneManager.LoadScene(11);
        }
    }
}
