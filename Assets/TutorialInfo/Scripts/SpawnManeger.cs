using UnityEngine;

public class SpawnManeger : MonoBehaviour
{
    public GameObject[] animalprefabs;
    private float rangeX = 18f;
    private float rangeZ = 20f;
    private float stdelay = 2f;
    private float intervel = 1.5f;
    
    void Start()
    {
        InvokeRepeating("SpanRandomAnimal", stdelay, intervel);
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
    void SpanRandomAnimal()
    {
        Vector3 SpanVar = new Vector3(Random.Range(-rangeX, rangeX), 0, rangeZ);
        int animalindex = Random.Range(0, animalprefabs.Length);
        Instantiate(animalprefabs[animalindex], SpanVar, animalprefabs[animalindex].transform.rotation);
    }
}
