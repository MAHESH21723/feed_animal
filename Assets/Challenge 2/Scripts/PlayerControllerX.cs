using UnityEngine;

public class PlayerContllorX : MonoBehaviour
{
    public GameObject dogPrefab;   // Assign Dog prefab in Inspector
    private GameObject currentDog; // Keeps track of the dog

    private Vector3 spawnPos = new Vector3(13, 0, 2);
    private int dogspeed = 20;
    void Update()
    {
        transform.Translate(Vector3.forward * dogspeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            // If a dog exists, destroy it
            if (currentDog != null)
            {
                Destroy(currentDog);
            }

            // Always spawn a new dog
            currentDog = Instantiate(dogPrefab, spawnPos, dogPrefab.transform.rotation);
        }
    }
}
