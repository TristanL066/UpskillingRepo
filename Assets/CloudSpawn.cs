using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject cloud;
    public float spawnrate = 1;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(-2, 5), 0), transform.rotation); 
    }
}
