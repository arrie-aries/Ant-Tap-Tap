using UnityEngine;
public class AntSpawn : MonoBehaviour
{
    // Instantiates prefabs in a circle formation
    public GameObject[] enemy;
    public float spawnTime = 3f;
    

    void Start()
    {
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        for (int i = 0; i < enemy.Length; i++)
        {
            Instantiate(enemy[i]);
            
            Debug.Log("Enemy number spawned " + i);
        }
        //Memduplikasi enemy
    }
}