using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject BigAsteroid;
    public GameObject SmallAsteroid;
    public GameObject MedAsteroid;
    public float MaxSpawnableAmountOfAsteroids;
    public int AliveAsteroids;
    public int Score;
    bool WasInvocked;
    bool CanStart;


    void Start()
    {

    }

    void Update()
    {
        if (Input.anyKey)
        {
            CanStart = true;
        }
        
        if(AliveAsteroids != MaxSpawnableAmountOfAsteroids && !WasInvocked && CanStart)
        {
            WasInvocked = true;
            Spawn();
        }
    }

    void Spawn()
    {
        AliveAsteroids++;
        float RandomInt = (Mathf.Round(Random.Range(1f, 3f)));
        
        if(RandomInt == 1)
        {
            Instantiate(BigAsteroid);
        }
        
        else if(RandomInt == 2)
        {
            Instantiate(MedAsteroid);
        }
        else if(RandomInt == 3)
        {
            Instantiate(SmallAsteroid);
            Instantiate(SmallAsteroid);
            AliveAsteroids++;
        }

        RandomInt = 0;
    }

    public void DecremetAliveAsteroids()
    {
        AliveAsteroids -= 1;
        WasInvocked = false;
        Score++;
    }
}
